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
            showRecipeList();
            setCategory();
        }
        //레시피 리스트 보이기
        private void showRecipeList()
        {
            updateRecipeContents();

            if (recipeContent == null)
            {
                recipeList.Rows.Add("새로운 레시피를 추가해주세요");
            }
            else
            {
                foreach (var recipe in recipeContent)
                {
                    string name = recipe[(int)DataIndex.Name].Split('.')[0];
                    string level = recipe[(int)DataIndex.Level].Split(',')[0];

                    recipeList.Rows.Add(name, level);
                }
            }

        }

        //레시피 가져오기
        private void updateRecipeContents()
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

        private void recipeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
