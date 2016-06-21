namespace BigBucksBank
{
    partial class AdminControl
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
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAccounts
            // 
            this.lbAccounts.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 22;
            this.lbAccounts.Location = new System.Drawing.Point(97, 67);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(444, 180);
            this.lbAccounts.TabIndex = 0;
            // 
            // btnControl
            // 
            this.btnControl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnControl.Location = new System.Drawing.Point(423, 294);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(118, 50);
            this.btnControl.TabIndex = 1;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDone.Location = new System.Drawing.Point(97, 294);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(105, 50);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 410);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.lbAccounts);
            this.Name = "AdminControl";
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnDone;
    }
}