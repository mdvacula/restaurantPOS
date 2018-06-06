namespace RestaurantPOSFINAL
{
    partial class Check
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
            this.orderedItems = new System.Windows.Forms.ListBox();
            this.categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuItemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.removeItem = new System.Windows.Forms.Button();
            this.printItem = new System.Windows.Forms.Button();
            this.makePayment = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderedItems
            // 
            this.orderedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderedItems.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedItems.FormattingEnabled = true;
            this.orderedItems.ItemHeight = 23;
            this.orderedItems.Location = new System.Drawing.Point(703, 95);
            this.orderedItems.Name = "orderedItems";
            this.orderedItems.Size = new System.Drawing.Size(663, 579);
            this.orderedItems.TabIndex = 0;
            this.orderedItems.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatList);
            // 
            // categoryPanel
            // 
            this.categoryPanel.AutoScroll = true;
            this.categoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPanel.Location = new System.Drawing.Point(10, 12);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(687, 226);
            this.categoryPanel.TabIndex = 2;
            // 
            // menuItemBox
            // 
            this.menuItemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuItemBox.AutoScroll = true;
            this.menuItemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuItemBox.Location = new System.Drawing.Point(10, 244);
            this.menuItemBox.Name = "menuItemBox";
            this.menuItemBox.Size = new System.Drawing.Size(687, 507);
            this.menuItemBox.TabIndex = 3;
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(703, 12);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(219, 77);
            this.removeItem.TabIndex = 4;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // printItem
            // 
            this.printItem.Location = new System.Drawing.Point(927, 12);
            this.printItem.Name = "printItem";
            this.printItem.Size = new System.Drawing.Size(219, 77);
            this.printItem.TabIndex = 5;
            this.printItem.Text = "Print";
            this.printItem.UseVisualStyleBackColor = true;
            this.printItem.Click += new System.EventHandler(this.printItem_Click);
            // 
            // makePayment
            // 
            this.makePayment.BackColor = System.Drawing.Color.LightGreen;
            this.makePayment.Location = new System.Drawing.Point(1153, 12);
            this.makePayment.Name = "makePayment";
            this.makePayment.Size = new System.Drawing.Size(213, 77);
            this.makePayment.TabIndex = 6;
            this.makePayment.Text = "Pay";
            this.makePayment.UseVisualStyleBackColor = false;
            this.makePayment.Click += new System.EventHandler(this.makePayment_Click);
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(946, 688);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(419, 37);
            this.totalBox.TabIndex = 8;
            this.totalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Blue;
            this.totalLabel.Location = new System.Drawing.Point(801, 691);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(121, 30);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // Check
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1378, 763);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.makePayment);
            this.Controls.Add(this.printItem);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.menuItemBox);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.orderedItems);
            this.IsMdiContainer = true;
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderedItems;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.FlowLayoutPanel menuItemBox;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button printItem;
        private System.Windows.Forms.Button makePayment;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label totalLabel;
    }
}