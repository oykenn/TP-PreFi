namespace Inventory
{
    partial class frmAddProduct
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
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelMfgdate = new System.Windows.Forms.Label();
            this.dateTimePickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelSellPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.dataGridViewProductLIst = new System.Windows.Forms.DataGridView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductLIst)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.labelAddProduct.Location = new System.Drawing.Point(20, 27);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(207, 39);
            this.labelAddProduct.TabIndex = 0;
            this.labelAddProduct.Text = "Add Product";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(27, 120);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(86, 25);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Product";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(140, 116);
            this.textBoxProductName.Multiline = true;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(359, 36);
            this.textBoxProductName.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(27, 178);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(99, 25);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Beverages Bread",
            "Bakery Canned",
            "Jarred Goods ",
            "Dairy Frozen ",
            "Goods Meat ",
            "Personal Care Other"});
            this.comboBoxCategory.Location = new System.Drawing.Point(140, 178);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(359, 33);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // labelMfgdate
            // 
            this.labelMfgdate.AutoSize = true;
            this.labelMfgdate.Location = new System.Drawing.Point(27, 245);
            this.labelMfgdate.Name = "labelMfgdate";
            this.labelMfgdate.Size = new System.Drawing.Size(105, 25);
            this.labelMfgdate.TabIndex = 5;
            this.labelMfgdate.Text = "Mfg. Date";
            // 
            // dateTimePickerMfgDate
            // 
            this.dateTimePickerMfgDate.Location = new System.Drawing.Point(140, 245);
            this.dateTimePickerMfgDate.Name = "dateTimePickerMfgDate";
            this.dateTimePickerMfgDate.Size = new System.Drawing.Size(359, 31);
            this.dateTimePickerMfgDate.TabIndex = 6;
            // 
            // dateTimePickerExpDate
            // 
            this.dateTimePickerExpDate.Location = new System.Drawing.Point(140, 306);
            this.dateTimePickerExpDate.Name = "dateTimePickerExpDate";
            this.dateTimePickerExpDate.Size = new System.Drawing.Size(359, 31);
            this.dateTimePickerExpDate.TabIndex = 8;
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Location = new System.Drawing.Point(27, 306);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(106, 25);
            this.labelExpDate.TabIndex = 7;
            this.labelExpDate.Text = "Exp. Date";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(30, 375);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(51, 25);
            this.labelQty.TabIndex = 9;
            this.labelQty.Text = "Qty.";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(140, 370);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(359, 36);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(140, 435);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(359, 36);
            this.textBoxPrice.TabIndex = 12;
            // 
            // labelSellPrice
            // 
            this.labelSellPrice.AutoSize = true;
            this.labelSellPrice.Location = new System.Drawing.Point(27, 435);
            this.labelSellPrice.Name = "labelSellPrice";
            this.labelSellPrice.Size = new System.Drawing.Size(103, 25);
            this.labelSellPrice.TabIndex = 11;
            this.labelSellPrice.Text = "Sell Price";
            this.labelSellPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(538, 116);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(543, 153);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(581, 318);
            this.richTextBoxDescription.TabIndex = 14;
            this.richTextBoxDescription.Text = "";
            // 
            // dataGridViewProductLIst
            // 
            this.dataGridViewProductLIst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductLIst.Location = new System.Drawing.Point(27, 556);
            this.dataGridViewProductLIst.Name = "dataGridViewProductLIst";
            this.dataGridViewProductLIst.RowHeadersWidth = 82;
            this.dataGridViewProductLIst.RowTemplate.Height = 33;
            this.dataGridViewProductLIst.Size = new System.Drawing.Size(1097, 415);
            this.dataGridViewProductLIst.TabIndex = 15;
            this.dataGridViewProductLIst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductLIst_CellContentClick);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(543, 477);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(181, 38);
            this.buttonAddProduct.TabIndex = 16;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 1083);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dataGridViewProductLIst);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelSellPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.dateTimePickerExpDate);
            this.Controls.Add(this.labelExpDate);
            this.Controls.Add(this.dateTimePickerMfgDate);
            this.Controls.Add(this.labelMfgdate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelAddProduct);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductLIst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelMfgdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMfgDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpDate;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelSellPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.DataGridView dataGridViewProductLIst;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}

