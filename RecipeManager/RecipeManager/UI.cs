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
        enum DataIndex
        {
            Name,
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
        }

        //레시피 목록 보이게 하기
        private void showRecipeList()
        {
            List<List<string>> recipeContent = new FileIO().GetFileContent();

            if(recipeContent == null)
            {
                recipeList.Rows.Add("새로운 레시피를 추가해주세요");
            }
            else
            {
                foreach(var recipe in recipeContent)
                {
                    string name = recipe[(int)DataIndex.Name];
                    string level = recipe[(int)DataIndex.Level];

                    recipeList.Rows.Add(name, level);
                }
            }
        }

        private void recipeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
