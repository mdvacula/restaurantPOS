namespace RestaurantPOSFINAL
{
    partial class AddProduct
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
            this.addItemBut = new System.Windows.Forms.Button();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addItemBut
            // 
            this.addItemBut.Location = new System.Drawing.Point(147, 323);
            this.addItemBut.Name = "addItemBut";
            this.addItemBut.Size = new System.Drawing.Size(168, 49);
            this.addItemBut.TabIndex = 0;
            this.addItemBut.Text = "Add Item";
            this.addItemBut.UseVisualStyleBackColor = true;
            this.addItemBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(84, 81);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(79, 17);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "Description";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(84, 126);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(40, 17);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "Price";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(84, 168);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(65, 17);
            this.categoryLbl.TabIndex = 3;
            this.categoryLbl.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(177, 165);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(114, 24);
            this.categoryBox.TabIndex = 4;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(177, 126);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(125, 22);
            this.priceTxt.TabIndex = 5;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(177, 76);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(125, 22);
            this.descriptionTxt.TabIndex = 6;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.addItemBut);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItemBut;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
    }
}

