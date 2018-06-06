namespace RestaurantPOSFINAL
{
    partial class logIn
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
            this.logInBut = new System.Windows.Forms.Button();
            this.employeeID = new System.Windows.Forms.Label();
            this.employeeIDTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logInBut
            // 
            this.logInBut.Location = new System.Drawing.Point(174, 340);
            this.logInBut.Name = "logInBut";
            this.logInBut.Size = new System.Drawing.Size(173, 68);
            this.logInBut.TabIndex = 0;
            this.logInBut.Text = "Log In";
            this.logInBut.UseVisualStyleBackColor = true;
            this.logInBut.Click += new System.EventHandler(this.logInBut_Click);
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID.Location = new System.Drawing.Point(44, 217);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(216, 28);
            this.employeeID.TabIndex = 1;
            this.employeeID.Text = "Employee ID:";
            // 
            // employeeIDTxt
            // 
            this.employeeIDTxt.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTxt.Location = new System.Drawing.Point(266, 214);
            this.employeeIDTxt.Name = "employeeIDTxt";
            this.employeeIDTxt.Size = new System.Drawing.Size(152, 34);
            this.employeeIDTxt.TabIndex = 2;
            // 
            // logIn
            // 
            this.AcceptButton = this.logInBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 561);
            this.Controls.Add(this.employeeIDTxt);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.logInBut);
            this.Name = "logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInBut;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.TextBox employeeIDTxt;
    }
}