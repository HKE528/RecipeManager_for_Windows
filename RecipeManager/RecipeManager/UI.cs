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

        //레시피 리스트 보이기
        private void showRecipeList(string category)
        {
            recipeList.Rows.Clear();

            if (recipeContent == null)
            {
                recipeList.Rows.Add("새로운 레시피를 추가해주세요");
            }
            else if(category == "전체")
            {
                foreach (var recipe in recipeContent)
                {
                    string name = recipe[(int)DataIndex.Name].Split('.')[0];
                    string level = recipe[(int)DataIndex.Level].Split(',')[0];

                    recipeList.Rows.Add(name, level);
                }
            }
            else
            {
                foreach (var recipe in recipeContent)
                {
                    string cate = recipe[(int)DataIndex.Category].Split(',')[0];
                    if (cate == category)
                    {
                        string name = recipe[(int)DataIndex.Name].Split('.')[0];
                        string level = recipe[(int)DataIndex.Level].Split(',')[0];

                        recipeList.Rows.Add(name, level);
                    }
                }
            }
        }

        private void recipeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //카테고리별 리스트 출력
            string category = CategoryCombo.SelectedItem.ToString();
            showRecipeList(category);
        }
    }
}
