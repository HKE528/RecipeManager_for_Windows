using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class UI : Form
    {
        Recipe recipe;

        public UI()
        {
            InitializeComponent();

            recipe = new Recipe();

            setCategory();

            CategoryCombo.SelectedIndex = 0;
            orderByCombo.SelectedIndex = 0;
        }

        //카테고리 세팅
        private void setCategory()
        {
            List<List<string>> recipeContent = recipe.recipeContents;

            CategoryCombo.Items.Add("전체");
            foreach (var recipe in recipeContent)
            {
                string category = recipe[(int)DataIndex.Category].Split(',')[0];

                CategoryCombo.Items.Add(category);
            }
        }

        //레시피 보이기
        private void showRecipeList()
        {
            recipeList.Rows.Clear();

            Dictionary<string, string> recipeTitle = SetRecipeTitle();
            foreach (var name in recipeTitle.Keys)
            {
                recipeList.Rows.Add(name, recipeTitle[name]);
            }
        }
        private void showRecipeList(string targetName)
        {
            recipeList.Rows.Clear();

            Dictionary<string, string> recipeTitle = SetRecipeTitle();
            foreach (var name in recipeTitle.Keys)
            {
                if (name.Contains(targetName))
                    recipeList.Rows.Add(name, recipeTitle[name]);
            }

        }

        private Dictionary<string, string> SetRecipeTitle()
        {
            string category = CategoryCombo.SelectedItem.ToString();
            int index = orderByCombo.SelectedIndex;

            return recipe.GetRecipeList(category, index);
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //카테고리별 리스트 출력
            showRecipeList();
        }

        private void orderByCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //난이도, 시간 선택에 따라 표시
            showRecipeList();
        }

        //검색
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;

            if (name != "")
                showRecipeList(name);
            else
                showRecipeList();
        }
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        //리스트에서 선택시 해당 레시피 표시
        private void recipeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectRow = e.RowIndex;
            string curSelectName = recipe.GetSelectName(selectRow);
            List<string> curSelectContent = recipe.GetSelectContent(curSelectName);
            if(curSelectContent == null)
            {
                MessageBox.Show("Error : 선택한 레시피의 데이터를 블러올 수 없습니다.");
                return;
            }

            int i = 1;
            lbRecipe.Text += " 주재표" + Environment.NewLine;
            foreach(var food in curSelectContent[(int)DataIndex.Main].Split(','))
            {
                lbRecipe.Text += (i++).ToString() + ". " + food + Environment.NewLine;
            }

            
            if (curSelectContent[(int)DataIndex.Sub].Split(',')[0] != "")
            {
                lbRecipe.Text += Environment.NewLine + Environment.NewLine;
                lbRecipe.Text += "부재료" + Environment.NewLine;
                foreach (var food in curSelectContent[(int)DataIndex.Sub].Split(','))
                {
                    lbRecipe.Text += (i++).ToString() + ". " + food + Environment.NewLine;
                }
            }
        }
    }
}
