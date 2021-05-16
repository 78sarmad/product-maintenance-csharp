namespace Product_Maintenance
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductIDInput = new System.Windows.Forms.TextBox();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MfgDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Maintenance Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Products Inventory";
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteProductBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteProductBtn.Location = new System.Drawing.Point(363, 484);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(167, 55);
            this.DeleteProductBtn.TabIndex = 3;
            this.DeleteProductBtn.Text = "Delete Selected Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddProductBtn.Location = new System.Drawing.Point(847, 491);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(137, 48);
            this.AddProductBtn.TabIndex = 4;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add New Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(725, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product ID";
            // 
            // ProductIDInput
            // 
            this.ProductIDInput.Location = new System.Drawing.Point(729, 158);
            this.ProductIDInput.Name = "ProductIDInput";
            this.ProductIDInput.Size = new System.Drawing.Size(255, 22);
            this.ProductIDInput.TabIndex = 7;
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Location = new System.Drawing.Point(729, 224);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(255, 22);
            this.ProductNameInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(725, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Name";
            // 
            // ProductPriceInput
            // 
            this.ProductPriceInput.Location = new System.Drawing.Point(729, 292);
            this.ProductPriceInput.Name = "ProductPriceInput";
            this.ProductPriceInput.Size = new System.Drawing.Size(255, 22);
            this.ProductPriceInput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(725, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Product Price";
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToAddRows = false;
            this.ProductsGrid.AllowUserToDeleteRows = false;
            this.ProductsGrid.AllowUserToResizeRows = false;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Location = new System.Drawing.Point(17, 128);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.Size = new System.Drawing.Size(673, 331);
            this.ProductsGrid.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "(click arrow to select row)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveChangesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveChangesBtn.Location = new System.Drawing.Point(549, 484);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(141, 55);
            this.SaveChangesBtn.TabIndex = 16;
            this.SaveChangesBtn.Text = "Save Changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(725, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Manufacturing Date";
            // 
            // MfgDatePicker
            // 
            this.MfgDatePicker.Location = new System.Drawing.Point(729, 362);
            this.MfgDatePicker.Name = "MfgDatePicker";
            this.MfgDatePicker.Size = new System.Drawing.Size(255, 22);
            this.MfgDatePicker.TabIndex = 21;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.Location = new System.Drawing.Point(730, 437);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(255, 22);
            this.ExpiryDatePicker.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(726, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Expiry Date";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 575);
            this.Controls.Add(this.ExpiryDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MfgDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SaveChangesBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.ProductPriceInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductIDInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Product Maintenance Software";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductIDInput;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker MfgDatePicker;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.Label label9;
    }
}

