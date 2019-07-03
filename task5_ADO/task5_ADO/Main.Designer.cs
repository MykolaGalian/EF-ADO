namespace task5_ADO
{
    partial class Main
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
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btQueryProdPerCategory = new System.Windows.Forms.Button();
            this.btQueryProdPerSupplier = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbSupplierCity = new System.Windows.Forms.ComboBox();
            this.btQueryPrice = new System.Windows.Forms.Button();
            this.btQuerySupplierCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToOrderColumns = true;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(10, 30);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(439, 150);
            this.dgvProd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cписок товаров, поставщиков, категории товаров";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(17, 203);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(212, 21);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск по категории товара";
            // 
            // btQueryProdPerCategory
            // 
            this.btQueryProdPerCategory.Location = new System.Drawing.Point(248, 201);
            this.btQueryProdPerCategory.Name = "btQueryProdPerCategory";
            this.btQueryProdPerCategory.Size = new System.Drawing.Size(75, 23);
            this.btQueryProdPerCategory.TabIndex = 4;
            this.btQueryProdPerCategory.Text = "Ok";
            this.btQueryProdPerCategory.UseVisualStyleBackColor = true;
            this.btQueryProdPerCategory.Click += new System.EventHandler(this.BtQueryProdPerCategory_Click);
            // 
            // btQueryProdPerSupplier
            // 
            this.btQueryProdPerSupplier.Location = new System.Drawing.Point(248, 251);
            this.btQueryProdPerSupplier.Name = "btQueryProdPerSupplier";
            this.btQueryProdPerSupplier.Size = new System.Drawing.Size(75, 23);
            this.btQueryProdPerSupplier.TabIndex = 12;
            this.btQueryProdPerSupplier.Text = "Ok";
            this.btQueryProdPerSupplier.UseVisualStyleBackColor = true;
            this.btQueryProdPerSupplier.Click += new System.EventHandler(this.BtQueryProdPerSupplier_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(17, 252);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(212, 21);
            this.cbSupplier.TabIndex = 11;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.CbSupplier_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поиск по поставщику";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Поиск товаров с заданной ценой ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Поиск поставщиков из выбраного города";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(20, 354);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(209, 20);
            this.tbPrice.TabIndex = 15;
          
            // 
            // cbSupplierCity
            // 
            this.cbSupplierCity.FormattingEnabled = true;
            this.cbSupplierCity.Location = new System.Drawing.Point(19, 305);
            this.cbSupplierCity.Name = "cbSupplierCity";
            this.cbSupplierCity.Size = new System.Drawing.Size(209, 21);
            this.cbSupplierCity.TabIndex = 16;
            this.cbSupplierCity.SelectedIndexChanged += new System.EventHandler(this.CbSupplierCity_SelectedIndexChanged);
            // 
            // btQueryPrice
            // 
            this.btQueryPrice.Location = new System.Drawing.Point(248, 352);
            this.btQueryPrice.Name = "btQueryPrice";
            this.btQueryPrice.Size = new System.Drawing.Size(75, 23);
            this.btQueryPrice.TabIndex = 17;
            this.btQueryPrice.Text = "Ok";
            this.btQueryPrice.UseVisualStyleBackColor = true;
            this.btQueryPrice.Click += new System.EventHandler(this.BtQueryPrice_Click);
            // 
            // btQuerySupplierCity
            // 
            this.btQuerySupplierCity.Location = new System.Drawing.Point(247, 305);
            this.btQuerySupplierCity.Name = "btQuerySupplierCity";
            this.btQuerySupplierCity.Size = new System.Drawing.Size(75, 23);
            this.btQuerySupplierCity.TabIndex = 17;
            this.btQuerySupplierCity.Text = "Ok";
            this.btQuerySupplierCity.UseVisualStyleBackColor = true;
            this.btQuerySupplierCity.Click += new System.EventHandler(this.BtQuerySupplierCity_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 595);
            this.Controls.Add(this.btQuerySupplierCity);
            this.Controls.Add(this.btQueryPrice);
            this.Controls.Add(this.cbSupplierCity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQueryProdPerSupplier);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btQueryProdPerCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProd);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TASK 5 - EF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQueryProdPerCategory;
        private System.Windows.Forms.Button btQueryProdPerSupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cbSupplierCity;
        private System.Windows.Forms.Button btQueryPrice;
        private System.Windows.Forms.Button btQuerySupplierCity;
    }
}

