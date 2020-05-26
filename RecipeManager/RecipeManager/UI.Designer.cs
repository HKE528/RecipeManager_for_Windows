namespace RecipeManager
{
    partial class UI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.recipeListPanel = new System.Windows.Forms.Panel();
            this.recipeList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.funcBarPanel = new System.Windows.Forms.Panel();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.selectTable = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.orderByCombo = new System.Windows.Forms.ComboBox();
            this.btnPreContent = new System.Windows.Forms.Button();
            this.btnNextContent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createRecipe = new System.Windows.Forms.Panel();
            this.setRecipe = new System.Windows.Forms.Panel();
            this.setSubFood = new System.Windows.Forms.Panel();
            this.setMainFood = new System.Windows.Forms.Panel();
            this.inputRecipeTitle = new System.Windows.Forms.TableLayoutPanel();
            this.setTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setName = new System.Windows.Forms.TextBox();
            this.setLevel = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbRecipe = new System.Windows.Forms.Label();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.recipeListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeList)).BeginInit();
            this.panel1.SuspendLayout();
            this.funcBarPanel.SuspendLayout();
            this.selectTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.createRecipe.SuspendLayout();
            this.inputRecipeTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeListPanel
            // 
            this.recipeListPanel.Controls.Add(this.recipeList);
            this.recipeListPanel.Controls.Add(this.panel1);
            this.recipeListPanel.Location = new System.Drawing.Point(10, 10);
            this.recipeListPanel.Name = "recipeListPanel";
            this.recipeListPanel.Size = new System.Drawing.Size(300, 707);
            this.recipeListPanel.TabIndex = 0;
            // 
            // recipeList
            // 
            this.recipeList.AllowUserToAddRows = false;
            this.recipeList.AllowUserToDeleteRows = false;
            this.recipeList.AllowUserToResizeColumns = false;
            this.recipeList.AllowUserToResizeRows = false;
            this.recipeList.ColumnHeadersHeight = 34;
            this.recipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recipeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.level});
            this.recipeList.Location = new System.Drawing.Point(0, 45);
            this.recipeList.Name = "recipeList";
            this.recipeList.ReadOnly = true;
            this.recipeList.RowHeadersVisible = false;
            this.recipeList.RowHeadersWidth = 62;
            this.recipeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recipeList.RowTemplate.Height = 30;
            this.recipeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipeList.Size = new System.Drawing.Size(300, 616);
            this.recipeList.TabIndex = 2;
            this.recipeList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recipeList_CellMouseClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 80F;
            this.name.HeaderText = "이름";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // level
            // 
            this.level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.level.FillWeight = 46.89331F;
            this.level.HeaderText = "난이도";
            this.level.MinimumWidth = 8;
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Location = new System.Drawing.Point(0, 663);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("굴림", 12F);
            this.tbSearch.Location = new System.Drawing.Point(3, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(222, 35);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // funcBarPanel
            // 
            this.funcBarPanel.Controls.Add(this.btnUpdateRecipe);
            this.funcBarPanel.Controls.Add(this.btnCreateRecipe);
            this.funcBarPanel.Location = new System.Drawing.Point(1038, 10);
            this.funcBarPanel.Name = "funcBarPanel";
            this.funcBarPanel.Size = new System.Drawing.Size(124, 707);
            this.funcBarPanel.TabIndex = 2;
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.Font = new System.Drawing.Font("굴림", 14F);
            this.btnCreateRecipe.Location = new System.Drawing.Point(4, 4);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(117, 108);
            this.btnCreateRecipe.TabIndex = 0;
            this.btnCreateRecipe.Text = "레시피\r\n추가\r\n";
            this.btnCreateRecipe.UseVisualStyleBackColor = true;
            this.btnCreateRecipe.Click += new System.EventHandler(this.btnCreateRecipe_Click);
            // 
            // selectTable
            // 
            this.selectTable.ColumnCount = 2;
            this.selectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.33333F));
            this.selectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.66667F));
            this.selectTable.Controls.Add(this.CategoryCombo, 0, 0);
            this.selectTable.Controls.Add(this.orderByCombo, 1, 0);
            this.selectTable.Location = new System.Drawing.Point(10, 10);
            this.selectTable.Name = "selectTable";
            this.selectTable.RowCount = 1;
            this.selectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.56391F));
            this.selectTable.Size = new System.Drawing.Size(300, 43);
            this.selectTable.TabIndex = 0;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.Font = new System.Drawing.Font("굴림", 14F);
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(3, 3);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(180, 36);
            this.CategoryCombo.TabIndex = 0;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // orderByCombo
            // 
            this.orderByCombo.DisplayMember = "난이도";
            this.orderByCombo.Font = new System.Drawing.Font("굴림", 14F);
            this.orderByCombo.FormattingEnabled = true;
            this.orderByCombo.Items.AddRange(new object[] {
            "난이도",
            "시간"});
            this.orderByCombo.Location = new System.Drawing.Point(189, 3);
            this.orderByCombo.Name = "orderByCombo";
            this.orderByCombo.Size = new System.Drawing.Size(108, 36);
            this.orderByCombo.TabIndex = 1;
            this.orderByCombo.SelectedIndexChanged += new System.EventHandler(this.orderByCombo_SelectedIndexChanged);
            // 
            // btnPreContent
            // 
            this.btnPreContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreContent.Enabled = false;
            this.btnPreContent.Font = new System.Drawing.Font("굴림", 40F);
            this.btnPreContent.Location = new System.Drawing.Point(3, 3);
            this.btnPreContent.Name = "btnPreContent";
            this.btnPreContent.Size = new System.Drawing.Size(59, 701);
            this.btnPreContent.TabIndex = 1;
            this.btnPreContent.Text = "<";
            this.btnPreContent.UseVisualStyleBackColor = true;
            this.btnPreContent.Click += new System.EventHandler(this.btnPreContent_Click);
            // 
            // btnNextContent
            // 
            this.btnNextContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextContent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNextContent.Enabled = false;
            this.btnNextContent.Font = new System.Drawing.Font("굴림", 40F);
            this.btnNextContent.Location = new System.Drawing.Point(653, 3);
            this.btnNextContent.Name = "btnNextContent";
            this.btnNextContent.Size = new System.Drawing.Size(60, 701);
            this.btnNextContent.TabIndex = 2;
            this.btnNextContent.Text = ">";
            this.btnNextContent.UseVisualStyleBackColor = true;
            this.btnNextContent.Click += new System.EventHandler(this.btnNextContent_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.createRecipe);
            this.panel2.Controls.Add(this.lbRecipe);
            this.panel2.Controls.Add(this.btnNextContent);
            this.panel2.Controls.Add(this.btnPreContent);
            this.panel2.Location = new System.Drawing.Point(316, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 707);
            this.panel2.TabIndex = 3;
            // 
            // createRecipe
            // 
            this.createRecipe.Controls.Add(this.setRecipe);
            this.createRecipe.Controls.Add(this.setSubFood);
            this.createRecipe.Controls.Add(this.setMainFood);
            this.createRecipe.Controls.Add(this.inputRecipeTitle);
            this.createRecipe.Location = new System.Drawing.Point(72, 5);
            this.createRecipe.Name = "createRecipe";
            this.createRecipe.Size = new System.Drawing.Size(579, 701);
            this.createRecipe.TabIndex = 3;
            this.createRecipe.Visible = false;
            // 
            // setRecipe
            // 
            this.setRecipe.Location = new System.Drawing.Point(0, 0);
            this.setRecipe.Name = "setRecipe";
            this.setRecipe.Size = new System.Drawing.Size(572, 697);
            this.setRecipe.TabIndex = 1;
            this.setRecipe.Visible = false;
            // 
            // setSubFood
            // 
            this.setSubFood.Location = new System.Drawing.Point(0, 0);
            this.setSubFood.Name = "setSubFood";
            this.setSubFood.Size = new System.Drawing.Size(572, 697);
            this.setSubFood.TabIndex = 1;
            this.setSubFood.Visible = false;
            // 
            // setMainFood
            // 
            this.setMainFood.Location = new System.Drawing.Point(0, 0);
            this.setMainFood.Name = "setMainFood";
            this.setMainFood.Size = new System.Drawing.Size(572, 697);
            this.setMainFood.TabIndex = 1;
            this.setMainFood.Visible = false;
            // 
            // inputRecipeTitle
            // 
            this.inputRecipeTitle.ColumnCount = 2;
            this.inputRecipeTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.81119F));
            this.inputRecipeTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.18881F));
            this.inputRecipeTitle.Controls.Add(this.setTime, 1, 2);
            this.inputRecipeTitle.Controls.Add(this.label2, 0, 1);
            this.inputRecipeTitle.Controls.Add(this.label3, 0, 2);
            this.inputRecipeTitle.Controls.Add(this.label4, 0, 3);
            this.inputRecipeTitle.Controls.Add(this.label1, 0, 0);
            this.inputRecipeTitle.Controls.Add(this.setName, 1, 0);
            this.inputRecipeTitle.Controls.Add(this.setLevel, 1, 1);
            this.inputRecipeTitle.Controls.Add(this.comboBox1, 1, 3);
            this.inputRecipeTitle.Location = new System.Drawing.Point(4, 74);
            this.inputRecipeTitle.Name = "inputRecipeTitle";
            this.inputRecipeTitle.RowCount = 4;
            this.inputRecipeTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputRecipeTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputRecipeTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputRecipeTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputRecipeTitle.Size = new System.Drawing.Size(572, 463);
            this.inputRecipeTitle.TabIndex = 0;
            // 
            // setTime
            // 
            this.setTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setTime.Font = new System.Drawing.Font("굴림", 14F);
            this.setTime.Location = new System.Drawing.Point(225, 267);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(111, 40);
            this.setTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 115);
            this.label2.TabIndex = 1;
            this.label2.Text = "난이도 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 115);
            this.label3.TabIndex = 2;
            this.label3.Text = "소요 시간 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("굴림", 14F);
            this.label4.Location = new System.Drawing.Point(3, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 118);
            this.label4.TabIndex = 3;
            this.label4.Text = "카테고리 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setName
            // 
            this.setName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setName.Font = new System.Drawing.Font("굴림", 14F);
            this.setName.Location = new System.Drawing.Point(225, 37);
            this.setName.Name = "setName";
            this.setName.Size = new System.Drawing.Size(261, 40);
            this.setName.TabIndex = 4;
            // 
            // setLevel
            // 
            this.setLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setLevel.Font = new System.Drawing.Font("굴림", 14F);
            this.setLevel.FormattingEnabled = true;
            this.setLevel.ItemHeight = 28;
            this.setLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.setLevel.Location = new System.Drawing.Point(225, 156);
            this.setLevel.Name = "setLevel";
            this.setLevel.Size = new System.Drawing.Size(76, 32);
            this.setLevel.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 36);
            this.comboBox1.TabIndex = 7;
            // 
            // lbRecipe
            // 
            this.lbRecipe.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lbRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRecipe.Location = new System.Drawing.Point(68, 3);
            this.lbRecipe.Margin = new System.Windows.Forms.Padding(3);
            this.lbRecipe.Name = "lbRecipe";
            this.lbRecipe.Size = new System.Drawing.Size(579, 700);
            this.lbRecipe.TabIndex = 0;
            this.lbRecipe.Text = "lbRecipe";
            this.lbRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Font = new System.Drawing.Font("굴림", 14F);
            this.btnUpdateRecipe.Location = new System.Drawing.Point(4, 118);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(117, 108);
            this.btnUpdateRecipe.TabIndex = 1;
            this.btnUpdateRecipe.Text = "수정";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.selectTable);
            this.Controls.Add(this.funcBarPanel);
            this.Controls.Add(this.recipeListPanel);
            this.Name = "UI";
            this.Text = "Form1";
            this.recipeListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.funcBarPanel.ResumeLayout(false);
            this.selectTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.createRecipe.ResumeLayout(false);
            this.inputRecipeTitle.ResumeLayout(false);
            this.inputRecipeTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recipeListPanel;
        private System.Windows.Forms.Panel funcBarPanel;
        private System.Windows.Forms.TableLayoutPanel selectTable;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.ComboBox orderByCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView recipeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPreContent;
        private System.Windows.Forms.Button btnNextContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRecipe;
        private System.Windows.Forms.Panel createRecipe;
        private System.Windows.Forms.TableLayoutPanel inputRecipeTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setName;
        private System.Windows.Forms.ListBox setLevel;
        private System.Windows.Forms.TextBox setTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCreateRecipe;
        private System.Windows.Forms.Panel setMainFood;
        private System.Windows.Forms.Panel setSubFood;
        private System.Windows.Forms.Panel setRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
    }
}

