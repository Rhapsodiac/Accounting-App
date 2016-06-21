namespace BigBucksBank
{
    partial class UserControl
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
            this.btnControl = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.lblRecAccNum = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.rbChecking = new System.Windows.Forms.RadioButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtRecAccNum = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnControl.Location = new System.Drawing.Point(517, 619);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(118, 50);
            this.btnControl.TabIndex = 2;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCancel.Location = new System.Drawing.Point(125, 619);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.BackColor = System.Drawing.Color.Transparent;
            this.lblAccNum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(66, 319);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(317, 35);
            this.lblAccNum.TabIndex = 4;
            this.lblAccNum.Text = "Enter Account Number:";
            this.lblAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecAccNum
            // 
            this.lblRecAccNum.AutoSize = true;
            this.lblRecAccNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRecAccNum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecAccNum.Location = new System.Drawing.Point(66, 384);
            this.lblRecAccNum.Name = "lblRecAccNum";
            this.lblRecAccNum.Size = new System.Drawing.Size(465, 35);
            this.lblRecAccNum.TabIndex = 5;
            this.lblRecAccNum.Text = "Enter Recipient\'s Account Number:";
            this.lblRecAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(66, 507);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(203, 35);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Enter Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbSavings);
            this.gbType.Controls.Add(this.rbChecking);
            this.gbType.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.gbType.Location = new System.Drawing.Point(72, 107);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(588, 160);
            this.gbType.TabIndex = 13;
            this.gbType.TabStop = false;
            this.gbType.Text = "Select Account Type";
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.rbSavings.Location = new System.Drawing.Point(370, 84);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(125, 35);
            this.rbSavings.TabIndex = 11;
            this.rbSavings.Text = "Savings";
            this.rbSavings.UseVisualStyleBackColor = true;
            // 
            // rbChecking
            // 
            this.rbChecking.AutoSize = true;
            this.rbChecking.Checked = true;
            this.rbChecking.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.rbChecking.Location = new System.Drawing.Point(97, 84);
            this.rbChecking.Name = "rbChecking";
            this.rbChecking.Size = new System.Drawing.Size(145, 35);
            this.rbChecking.TabIndex = 10;
            this.rbChecking.TabStop = true;
            this.rbChecking.Text = "Checking";
            this.rbChecking.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.lblWelcome.Location = new System.Drawing.Point(234, 90);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 35);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccNum
            // 
            this.txtAccNum.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtAccNum.Location = new System.Drawing.Point(417, 316);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(237, 38);
            this.txtAccNum.TabIndex = 15;
            // 
            // txtRecAccNum
            // 
            this.txtRecAccNum.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtRecAccNum.Location = new System.Drawing.Point(417, 409);
            this.txtRecAccNum.Name = "txtRecAccNum";
            this.txtRecAccNum.Size = new System.Drawing.Size(237, 38);
            this.txtRecAccNum.TabIndex = 16;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtAmount.Location = new System.Drawing.Point(417, 508);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(237, 38);
            this.txtAmount.TabIndex = 17;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblControl.Location = new System.Drawing.Point(294, 33);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(0, 36);
            this.lblControl.TabIndex = 18;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 906);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRecAccNum);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblRecAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnControl);
            this.Name = "UserControl";
            this.Text = "UserControl";
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblRecAccNum;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbSavings;
        private System.Windows.Forms.RadioButton rbChecking;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.TextBox txtRecAccNum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblControl;
    }
}