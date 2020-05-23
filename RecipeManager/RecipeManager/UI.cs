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
            List<List<string>> recipeContent = recipe.recipeContent;

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

            string category = CategoryCombo.SelectedItem.ToString();
            int index = orderByCombo.SelectedIndex;

            Dictionary<string, string> recipeTitle = recipe.GetRecipeList(category, index);
            foreach (var name in recipeTitle.Keys)
            {
                recipeList.Rows.Add(name, recipeTitle[name]);
            }

        }
        private void showRecipeList(string targetName)
        {
            recipeList.Rows.Clear();

            string category = CategoryCombo.SelectedItem.ToString();
            int index = orderByCombo.SelectedIndex;

            Dictionary<string, string> recipeTitle = recipe.GetRecipeList(category, index);
            foreach (var name in recipeTitle.Keys)
            {
                if (name.Contains(targetName))
                    recipeList.Rows.Add(name, recipeTitle[name]);
            }

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
        private void recipeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
