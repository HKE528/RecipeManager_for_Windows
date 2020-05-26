using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    class UpdateRecipe : Form
    {
        RecipeData recipeData;
        List<string> curRecipe;
        Panel[] panels;
        CreateRecipe mainPanel;
        CreateRecipe subPanel;
        CreateRecipe contentPanel;

        public UpdateRecipe(List<string> curRecipe, UI master, params Panel[] panels)
        {

            recipeData = new RecipeData();
            this.curRecipe = curRecipe;
            this.panels = panels;

            mainPanel = new CreateRecipe(panels[1], "주재료");
            subPanel = new CreateRecipe(panels[2], "소스");
            contentPanel = new CreateRecipe(master, "레시피", panels[3], panels[0], panels[1], panels[2]);

            InitData();
            SetTitleText();
            SetFoodText();
        }

        private void InitData()
        {
            recipeData.name = curRecipe[(int)DataIndex.Name];
            recipeData.category = curRecipe[(int)DataIndex.Category];
            recipeData.level = curRecipe[(int)DataIndex.Level];
            recipeData.time = curRecipe[(int)DataIndex.Time];

            List<string> mains = new List<string>();
            foreach (string item in curRecipe[(int)DataIndex.Main].Split(','))
            {
                mains.Add(item);
            }
            recipeData.mainFood = mains;

            List<string> subs = new List<string>();
            if (curRecipe[(int)DataIndex.Sub].Length > 2)
            {
                foreach (string item in curRecipe[(int)DataIndex.Sub].Split(','))
                {
                    if (item.Split('"').Length > 1)
                        subs.Add(item.Split('"')[1]);
                    else
                        subs.Add(item);
                }
                recipeData.subFood = subs;
            }

            List<string> recipe = new List<string>();
            for (int i = (int)DataIndex.RecipeStart; i < curRecipe.Count; i++)
            {
                recipe.Add(curRecipe[i]);
            }
            recipeData.content = recipe;
        }

        private void SetTitleText()
        {
            for (int i = 0; i < panels[0].Controls[3].Controls.Count; i++)
            {
                if (panels[0].Controls[3].Controls[i].Name.Contains("Name"))
                    panels[0].Controls[3].Controls[i].Text = recipeData.name;
                else if (panels[0].Controls[3].Controls[i].Name == "setLevel")
                    ((ListBox)(panels[0].Controls[3].Controls[i])).SelectedIndex = int.Parse(recipeData.level);
                else if (panels[0].Controls[3].Controls[i].Name == "setTime")
                    panels[0].Controls[3].Controls[i].Text = recipeData.time;
                else if (panels[0].Controls[3].Controls[i].Name == "comboBox1")
                    ((ComboBox)panels[0].Controls[3].Controls[i]).SelectedItem = recipeData.category;
            }
        }

        private void SetFoodText()
        {
            foreach(string item in recipeData.mainFood)
            {
                Console.WriteLine(item);
                if(item.Length > 0)
                    mainPanel.AddInputDataPanel(item, new EventArgs());
            }

            if (recipeData.subFood != null)
            {
                foreach (string item in recipeData.subFood)
                {
                    Console.WriteLine(item);
                    if (item.Length > 0)
                        subPanel.AddInputDataPanel(item, new EventArgs());
                }
            }

            foreach (string item in recipeData.content)
            {
                Console.WriteLine(item);
                if (item.Length > 0)
                    contentPanel.AddInputDataPanel(item, new EventArgs());
            }
        }
    }
}
