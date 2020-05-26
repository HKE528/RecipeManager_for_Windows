using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace RecipeManager
{
    class CreateRecipe : Form
    {
        private Button foodPlus;
        private int boxCount;
        Panel curPanel;
        List<Panel> panels;
        RecipeData recipeData;
        UI master;
        public CreateRecipe(Panel curPanel, string name)
        {
            this.curPanel = curPanel;

            Init(name);
        }

        public CreateRecipe(UI master ,string name, Panel curPanel, params Panel[] otherPanel)
        {
            this.master = master;
            recipeData = new RecipeData();
            panels = new List<Panel>();

            this.curPanel = curPanel;
            
            foreach(var panel in otherPanel)
            {
                panels.Add(panel);
            }
            panels.Add(curPanel);

            boxCount = 0;

            Init(name);

            SaveRecipe();
        }
        private void Init(string name)
        {
            boxCount = 0;

            Label title = new Label();
            title.Text = name;
            title.Font = new Font(FontFamily.GenericSansSerif, 16f);
            title.Location = new Point(this.curPanel.Width / 2 - 20, 0);
            this.curPanel.Controls.Add(title);

            foodPlus = new Button();

            this.curPanel.Controls.Add(foodPlus);
            foodPlus.Name = "foodPlus";
            foodPlus.Text = "+";
            foodPlus.Location = new Point(this.curPanel.Width / 2 - 20, foodPlus.Location.Y + 30);

            foodPlus.Click += new EventHandler(this.AddInputDataPanel);
        }


        public void AddInputDataPanel(object sender, EventArgs e)
        {
            Panel aFood = new Panel();
            aFood.Size = new Size(350, 35);
            aFood.Location = new Point(foodPlus.Location.X - 140, foodPlus.Location.Y);
            aFood.Name = "aFoodPanel" + (boxCount + 1).ToString();

            Label number = new Label();
            number.Location = new Point(0, 0);
            number.Text = (boxCount + 1).ToString() + ". ";
            number.Font = new Font(FontFamily.GenericSansSerif, 14f);

            TextBox txFood = new TextBox();
            txFood.Location = new Point(40, 0);
            txFood.Size = new Size(250, 35);
            txFood.Font = new Font(FontFamily.GenericSansSerif, 14f);
            txFood.KeyUp += new KeyEventHandler(this.PressEnterKey);
            if(e.ToString() == (new EventArgs()).ToString())
                txFood.Text = sender.ToString();

            Button subPanel = new Button();
            subPanel.Location = new Point(300, 0);
            subPanel.Text = "-";
            subPanel.Size = new Size(30, 30);
            subPanel.Click += new EventHandler(this.RemoveInputDataPanel);

            aFood.Controls.Add(txFood);
            aFood.Controls.Add(number);
            aFood.Controls.Add(subPanel);
            curPanel.Controls.Add(aFood);

            txFood.Show();
            txFood.Focus();

            boxCount++; //현재까지 추가된 박스 수;
            //마지막 칸에만 (-) 버튼 보이게
            for (int i = 1; i < curPanel.Controls.Count; i++)
            {
                if (curPanel.Controls[i].Name ==
                        "aFoodPanel" + (boxCount - 1).ToString())
                {
                    curPanel.Controls[i].Controls[2].Visible = false;
                }
                else if (curPanel.Controls[i].Name ==
                    "aFoodPanel" + boxCount.ToString())
                {
                    curPanel.Controls[i].Controls[2].Visible = true;
                    break;
                }
            }

           foodPlus.Location =
                new Point(foodPlus.Location.X, foodPlus.Location.Y + 40);
        }

        private void RemoveInputDataPanel(object sender, EventArgs e)
        {
            //마지막 입력 칸 삭제 및 그 다음 마지막 칸에 (-) 버튼 활성화
            for (int i = 0; i < curPanel.Controls.Count; i++)
            {
                if (curPanel.Controls[i].Name ==
                        "aFoodPanel" + (boxCount - 1).ToString())
                {
                    curPanel.Controls[i].Controls[2].Visible = true;
                }
                else if (curPanel.Controls[i].Name ==
                    "aFoodPanel" + boxCount.ToString())
                {
                    Panel targetPanel = (Panel)curPanel.Controls[i];
                    curPanel.Controls.RemoveAt(i);
                    targetPanel.Dispose();
                    boxCount--;
                    break;
                }
            }

            //(+) 버튼 위치 이동
            foodPlus.Location =
                    new Point(foodPlus.Location.X, foodPlus.Location.Y - 40);
        }

        private void PressEnterKey(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                AddInputDataPanel(sender, e);
        }

        private void SaveRecipe()
        {
            Button save = new Button();
            save.Name = "btnSave";
            save.Text = "저장";
            save.Location = new Point(180, 430);
            save.Click += new EventHandler(this.ClickSaveButton);

            curPanel.Controls.Add(save);
        }

        private void ClickSaveButton(object sender, EventArgs e)
        {
            setTitle();
            setMainFood();
            setSubFood();
            setContent();

            
            bool success = (new FileIO()).SaveFile(recipeData);

            if (success)
            {
                PanelRefresh();
            }
        }
        public void PanelRefresh()
        {
            for (int i = 0; i < panels[0].Controls[3].Controls.Count; i++)
            {
                if (panels[0].Controls[3].Controls[i].Name.Contains("Name"))
                    panels[0].Controls[3].Controls[i].Text = "";
                else if (panels[0].Controls[3].Controls[i].Name == "setLevel")
                    ((ListBox)(panels[0].Controls[3].Controls[i])).SelectedIndex = 1;
                else if (panels[0].Controls[3].Controls[i].Name == "setTime")
                    panels[0].Controls[3].Controls[i].Text = "";
                else if (panels[0].Controls[3].Controls[i].Name == "comboBox1")
                    panels[0].Controls[3].Controls[i].Text = "";
            }

            master.RefreshList();

            panels[1].Controls.Clear();
            panels[2].Controls.Clear();
            curPanel.Controls.Clear();

            this.Close();
        }

        private void setTitle()
        {
            string name = "";
            string category = "";
            string level = "";
            string time = "";
                        
            for(int i = 0; i < panels[0].Controls[3].Controls.Count; i++)
            {
                if (panels[0].Controls[3].Controls[i].Name.Contains("Name"))
                    name = panels[0].Controls[3].Controls[i].Text;
                else if (panels[0].Controls[3].Controls[i].Name == "setLevel")
                {
                    if (((ListBox)(panels[0].Controls[3].Controls[i])).SelectedItem == null)
                        ((ListBox)(panels[0].Controls[3].Controls[i])).SelectedIndex = 1;
                    
                    level = ((ListBox)(panels[0].Controls[3].Controls[i])).SelectedItem.ToString();
                }
                else if (panels[0].Controls[3].Controls[i].Name == "setTime")
                    time = panels[0].Controls[3].Controls[i].Text;
                else if (panels[0].Controls[3].Controls[i].Name == "comboBox1")
                    category = panels[0].Controls[3].Controls[i].Text;
            }

            recipeData.name = name;
            recipeData.category = category;
            recipeData.level = level;
            recipeData.time = time;
        }
        private void setMainFood()
        {
            List<string> mainFood = new List<string>();

            for(int i = 0; i < panels[1].Controls.Count; i++)
            {
                if(panels[1].Controls[i].Name.Contains("aFood"))
                {
                    mainFood.Add(panels[1].Controls[i].Controls[0].Text);
                }
            }
            recipeData.mainFood = mainFood;
        }
        private void setSubFood()
        {
            List<string> subFood = new List<string>();

            for (int i = 0; i < panels[2].Controls.Count; i++)
            {
                if (panels[2].Controls[i].Name.Contains("aFood"))
                {
                    subFood.Add(panels[2].Controls[i].Controls[0].Text);
                }
            }
            recipeData.subFood = subFood;
        }
        private void setContent()
        {
            List<string> content = new List<string>();

            for (int i = 0; i < curPanel.Controls.Count; i++)
            {
                if (curPanel.Controls[i].Name.Contains("aFood"))
                {
                    content.Add(curPanel.Controls[i].Controls[0].Text);
                }
            }
            recipeData.content = content;
        }
    }
}
