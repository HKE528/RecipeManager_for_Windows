using System;
using System.Collections;
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
        private Recipe recipe;

        public UI()
        {
            InitializeComponent();

            recipe = new Recipe();

            setCategory();

            CategoryCombo.SelectedIndex = 0;
            orderByCombo.SelectedIndex = 0;
            lbRecipe.Text = "";
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
        List<string> curContent;
        private void recipeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbRecipe.Visible = true;
            createRecipe.Visible = false;
            btnNextContent.Enabled = true;

            int selectRow = e.RowIndex;
            string curSelectName = recipe.GetSelectName(selectRow);
            curContent = recipe.GetSelectContent(curSelectName);

            if(curContent == null)
            {
                MessageBox.Show("Error : 선택한 레시피의 데이터를 블러올 수 없습니다.");
                return;
            }

            showFoodmaterial();
        }

        int page;
        int maxPage;
        private void showFoodmaterial()
        {
            page = 1;
            maxPage = 2;
            int i = 1;

            lbRecipe.Text = "";

            lbRecipe.Text += " 주재표" + Environment.NewLine;
            foreach (var food in curContent[(int)DataIndex.Main].Split(','))
            {
                lbRecipe.Text += (i++).ToString() + ". " + food + Environment.NewLine;
            }
            if (curContent[(int)DataIndex.Sub].Split(',')[0] != "")
            {
                i = 1;
                lbRecipe.Text += Environment.NewLine + Environment.NewLine;
                lbRecipe.Text += " 소스" + Environment.NewLine;
                foreach (var food in curContent[(int)DataIndex.Sub].Split('"')[1].Split(','))
                {
                    if(food != "")
                        lbRecipe.Text += (i++).ToString() + ". " + food + Environment.NewLine;
                }
            }
        }
        private void btnPreContent_Click(object sender, EventArgs e)
        {
            page--;
            if(page == 1)
                btnPreContent.Enabled = false;
            btnNextContent.Enabled = true;

            //레시피 보이기
            if (lbRecipe.Visible == true)
                showFoodmaterial();

            //레시피 추가 상태 일때
            else if (createRecipe.Visible == true)
            {
                switch (page)
                {
                    case 1:
                        setMainFood.Visible = false;
                        break;
                    case 2:
                        setSubFood.Visible = false;
                        break;
                    case 3:
                        setRecipe.Visible = false;
                        break;
                }
            }
        }
        private void btnNextContent_Click(object sender, EventArgs e)
        {
            page++;
            btnPreContent.Enabled = true;
            if(page == maxPage)
                btnNextContent.Enabled = false;

            //레시피 보이기 일때
            if (lbRecipe.Visible == true)
            {
                lbRecipe.Text = "";

                for (int i = 1, j = (int)DataIndex.RecipeStart; j < curContent.Count(); i++, j++)
                {
                    lbRecipe.Text += i.ToString() + ". " + curContent[j].Split(',')[0] + Environment.NewLine;
                }
            }
            //레시피 추가 상태 일때
            else if (createRecipe.Visible == true)
            {
                switch (page)
                {
                    case 2:
                        setMainFood.Visible = true;
                        break;
                    case 3:
                        setSubFood.Visible = true;
                        break;
                    case 4:
                        setRecipe.Visible = true;
                        break;
                }
            }
        }

        private void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            CreateRecipe mainFoodPanel = new CreateRecipe(setMainFood, "주재료");
            CreateRecipe subFoodPanel = new CreateRecipe(setSubFood, "소스");
            CreateRecipe recipePanel = new CreateRecipe(setRecipe, "레시피");

            maxPage = 4;
            page = 1;

            lbRecipe.Visible = false;
            createRecipe.Visible = true;

            btnPreContent.Enabled = false;
            btnNextContent.Enabled = true;

            setMainFood.Visible = false;
            setSubFood.Visible = false;
            setRecipe.Visible = false;
        }
        private void saveRecipe()
        {
            Button save = new Button();
            save.Name = "btnSave";
            save.Text = "저장";
            save.Location = new Point(180, 430);

            //panel.Controls.Add(save);
        }
    }
}
