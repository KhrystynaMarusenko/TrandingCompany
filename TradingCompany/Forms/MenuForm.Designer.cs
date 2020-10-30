namespace Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_sign_out = new System.Windows.Forms.Button();
            this.tradingCompanyDataSet = new Forms.TradingCompanyDataSet();
            this.tradingCompanyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradingCompanyDataSet1 = new Forms.TradingCompanyDataSet1();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Forms.TradingCompanyDataSet1TableAdapters.CategoryTableAdapter();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new Forms.TradingCompanyDataSetTableAdapters.ItemTableAdapter();
            this.label_products = new System.Windows.Forms.Label();
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.reviewViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradingCompanyDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reviewTableAdapter = new Forms.TradingCompanyDataSetTableAdapters.ReviewTableAdapter();
            this.label_name = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_profile
            // 
            this.button_profile.FlatAppearance.BorderSize = 0;
            this.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.ForeColor = System.Drawing.Color.Green;
            this.button_profile.Location = new System.Drawing.Point(912, 78);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(91, 32);
            this.button_profile.TabIndex = 8;
            this.button_profile.Text = "My Profile";
            this.button_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_profile.UseVisualStyleBackColor = false;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_sign_out
            // 
            this.button_sign_out.FlatAppearance.BorderSize = 0;
            this.button_sign_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sign_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign_out.ForeColor = System.Drawing.Color.Green;
            this.button_sign_out.Location = new System.Drawing.Point(1028, 78);
            this.button_sign_out.Name = "button_sign_out";
            this.button_sign_out.Size = new System.Drawing.Size(87, 34);
            this.button_sign_out.TabIndex = 9;
            this.button_sign_out.Text = "Sign Out";
            this.button_sign_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sign_out.UseVisualStyleBackColor = false;
            this.button_sign_out.Click += new System.EventHandler(this.button_sign_out_Click);
            // 
            // tradingCompanyDataSet
            // 
            this.tradingCompanyDataSet.DataSetName = "TradingCompanyDataSet";
            this.tradingCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradingCompanyDataSetBindingSource
            // 
            this.tradingCompanyDataSetBindingSource.DataSource = this.tradingCompanyDataSet;
            this.tradingCompanyDataSetBindingSource.Position = 0;
            // 
            // tradingCompanyDataSet1
            // 
            this.tradingCompanyDataSet1.DataSetName = "TradingCompanyDataSet1";
            this.tradingCompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.tradingCompanyDataSet1;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_category
            // 
            this.comboBox_category.DataSource = this.categoryBindingSource;
            this.comboBox_category.DisplayMember = "Name";
            this.comboBox_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(135, 28);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(196, 28);
            this.comboBox_category.TabIndex = 10;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.Green;
            this.label_category.Location = new System.Drawing.Point(21, 31);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(86, 20);
            this.label_category.TabIndex = 11;
            this.label_category.Text = "Category:";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AutoGenerateColumns = false;
            this.dataGridViewItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewItems.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn});
            this.dataGridViewItems.DataSource = this.itemBindingSource;
            this.dataGridViewItems.Location = new System.Drawing.Point(23, 125);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 62;
            this.dataGridViewItems.RowTemplate.Height = 28;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.ShowEditingIcon = false;
            this.dataGridViewItems.Size = new System.Drawing.Size(1092, 156);
            this.dataGridViewItems.TabIndex = 12;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 380;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "In Stock";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.inStockDataGridViewTextBoxColumn.Width = 110;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.tradingCompanyDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.BackColor = System.Drawing.SystemColors.Control;
            this.label_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_products.ForeColor = System.Drawing.Color.Green;
            this.label_products.Location = new System.Drawing.Point(22, 92);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(85, 20);
            this.label_products.TabIndex = 13;
            this.label_products.Text = "Products:";
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.AllowUserToAddRows = false;
            this.dataGridViewReviews.AllowUserToDeleteRows = false;
            this.dataGridViewReviews.AutoGenerateColumns = false;
            this.dataGridViewReviews.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Item,
            this.textDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridViewReviews.DataSource = this.reviewBindingSource;
            this.dataGridViewReviews.Location = new System.Drawing.Point(23, 287);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.ReadOnly = true;
            this.dataGridViewReviews.RowHeadersWidth = 62;
            this.dataGridViewReviews.RowTemplate.Height = 28;
            this.dataGridViewReviews.Size = new System.Drawing.Size(1092, 190);
            this.dataGridViewReviews.TabIndex = 14;
            // 
            // reviewViewModelBindingSource
            // 
            this.reviewViewModelBindingSource.DataSource = typeof(BLL.Views.ReviewViewModel);
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataMember = "Review";
            this.reviewBindingSource.DataSource = this.tradingCompanyDataSet;
            // 
            // tradingCompanyDataSetBindingSource1
            // 
            this.tradingCompanyDataSetBindingSource1.DataSource = this.tradingCompanyDataSet;
            this.tradingCompanyDataSetBindingSource1.Position = 0;
            // 
            // reviewTableAdapter
            // 
            this.reviewTableAdapter.ClearBeforeFill = true;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_name.Location = new System.Drawing.Point(695, 28);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(420, 20);
            this.label_name.TabIndex = 15;
            this.label_name.Text = "User Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 8;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Width = 350;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date&Time";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 503);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridViewReviews);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.button_sign_out);
            this.Controls.Add(this.button_profile);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCompanyDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_sign_out;
        private TradingCompanyDataSet tradingCompanyDataSet;
        private System.Windows.Forms.BindingSource tradingCompanyDataSetBindingSource;
        private TradingCompanyDataSet1 tradingCompanyDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private TradingCompanyDataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private TradingCompanyDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.BindingSource tradingCompanyDataSetBindingSource1;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private TradingCompanyDataSetTableAdapters.ReviewTableAdapter reviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reviewViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    }
}