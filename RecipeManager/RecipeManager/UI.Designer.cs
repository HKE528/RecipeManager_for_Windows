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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.showRecipePanel = new System.Windows.Forms.Panel();
            this.funcBarPanel = new System.Windows.Forms.Panel();
            this.selectTable = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.orderByCombo = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.recipeListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeList)).BeginInit();
            this.panel1.SuspendLayout();
            this.selectTable.SuspendLayout();
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
            this.recipeList.RowTemplate.Height = 30;
            this.recipeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipeList.Size = new System.Drawing.Size(300, 616);
            this.recipeList.TabIndex = 2;
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
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("굴림", 12F);
            this.tbSearch.Location = new System.Drawing.Point(3, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(222, 35);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // showRecipePanel
            // 
            this.showRecipePanel.Location = new System.Drawing.Point(316, 10);
            this.showRecipePanel.Name = "showRecipePanel";
            this.showRecipePanel.Size = new System.Drawing.Size(718, 707);
            this.showRecipePanel.TabIndex = 1;
            // 
            // funcBarPanel
            // 
            this.funcBarPanel.Location = new System.Drawing.Point(1041, 10);
            this.funcBarPanel.Name = "funcBarPanel";
            this.funcBarPanel.Size = new System.Drawing.Size(121, 707);
            this.funcBarPanel.TabIndex = 2;
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
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.selectTable);
            this.Controls.Add(this.funcBarPanel);
            this.Controls.Add(this.showRecipePanel);
            this.Controls.Add(this.recipeListPanel);
            this.Name = "UI";
            this.Text = "Form1";
            this.recipeListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recipeListPanel;
        private System.Windows.Forms.Panel showRecipePanel;
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
    }
}

