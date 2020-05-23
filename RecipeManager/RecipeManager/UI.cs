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
        List<List<string>> recipeContent;

        enum DataIndex
        {
            Name,
            Category,
            Level,
            Time,
            Main,
            Sub,
            RecipeStart
        };

        public UI()
        {
            InitializeComponent();

            InitData();
        }

        private void InitData()
        {
            updateAllRecipeContents();
            setCategory();

            CategoryCombo.SelectedIndex = 0;
            orderByCombo.SelectedIndex = 0;
        }

        //레시피 가져오기
        private void updateAllRecipeContents()
        {
            recipeContent = new FileIO().GetFileContent();
        }

        //카테고리 세팅
        private void setCategory()
        {
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

            if (recipeContent == null)
            {
                recipeList.Rows.Add("새로운 레시피를 추가해주세요");
            }
            else
            {
                foreach (var recipe in recipeContent)
                {
                    string targetCategory = recipe[(int)DataIndex.Category].Split(',')[0];

                    if (category != targetCategory && category != "전체")
                        continue;

                    string name = recipe[(int)DataIndex.Name].Split('.')[0];
                    string sub = index == 0 ? recipe[(int)DataIndex.Level].Split(',')[0] :
                        recipe[(int)DataIndex.Time].Split(',')[0];

                    recipeList.Rows.Add(name, sub);
                }
            }
        }

        private void showRecipeList(string targetName)
        {
            recipeList.Rows.Clear();

            string category = CategoryCombo.SelectedItem.ToString();
            int index = orderByCombo.SelectedIndex;

            if (recipeContent == null)
            {
                recipeList.Rows.Add("새로운 레시피를 추가해주세요");
            }
            else
            {
                foreach (var recipe in recipeContent)
                {
                    string targetCategory = recipe[(int)DataIndex.Category].Split(',')[0];

                    if (category != targetCategory && category != "전체")
                        continue;

                    string name = recipe[(int)DataIndex.Name].Split('.')[0];
                    string sub = index == 0 ? recipe[(int)DataIndex.Level].Split(',')[0] :
                        recipe[(int)DataIndex.Time].Split(',')[0];

                    if(name.Contains(targetName))
                        recipeList.Rows.Add(name, sub);
                }
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
    }
}
