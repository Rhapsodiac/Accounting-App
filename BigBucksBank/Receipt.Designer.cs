namespace BigBucksBank
{
    partial class Receipt
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
            this.lblAccNum = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtAccS = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBalS = new System.Windows.Forms.TextBox();
            this.txtAccC = new System.Windows.Forms.TextBox();
            this.txtBalC = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.BackColor = System.Drawing.Color.Transparent;
            this.lblAccNum.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccNum.Location = new System.Drawing.Point(61, 149);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(94, 26);
            this.lblAccNum.TabIndex = 5;
            this.lblAccNum.Text = "UserID:";
            this.lblAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(61, 311);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(246, 26);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount of Transaction";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblAcc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblAcc.Location = new System.Drawing.Point(61, 232);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(114, 26);
            this.lblAcc.TabIndex = 7;
            this.lblAcc.Text = "Accounts:";
            this.lblAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.BackColor = System.Drawing.Color.Transparent;
            this.lblBal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblBal.Location = new System.Drawing.Point(61, 389);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(409, 26);
            this.lblBal.TabIndex = 9;
            this.lblBal.Text = "Current Balances (Checking, Savings):";
            this.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Successful Transaction!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtUserID.Location = new System.Drawing.Point(260, 143);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(325, 38);
            this.txtUserID.TabIndex = 16;
            // 
            // txtAccS
            // 
            this.txtAccS.Enabled = false;
            this.txtAccS.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtAccS.Location = new System.Drawing.Point(444, 226);
            this.txtAccS.Name = "txtAccS";
            this.txtAccS.ReadOnly = true;
            this.txtAccS.Size = new System.Drawing.Size(141, 38);
            this.txtAccS.TabIndex = 17;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtAmount.Location = new System.Drawing.Point(348, 305);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(237, 38);
            this.txtAmount.TabIndex = 18;
            // 
            // txtBalS
            // 
            this.txtBalS.Enabled = false;
            this.txtBalS.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtBalS.Location = new System.Drawing.Point(369, 458);
            this.txtBalS.Name = "txtBalS";
            this.txtBalS.ReadOnly = true;
            this.txtBalS.Size = new System.Drawing.Size(216, 38);
            this.txtBalS.TabIndex = 20;
            // 
            // txtAccC
            // 
            this.txtAccC.Enabled = false;
            this.txtAccC.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtAccC.Location = new System.Drawing.Point(260, 226);
            this.txtAccC.Name = "txtAccC";
            this.txtAccC.ReadOnly = true;
            this.txtAccC.Size = new System.Drawing.Size(154, 38);
            this.txtAccC.TabIndex = 21;
            // 
            // txtBalC
            // 
            this.txtBalC.Enabled = false;
            this.txtBalC.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtBalC.Location = new System.Drawing.Point(82, 458);
            this.txtBalC.Name = "txtBalC";
            this.txtBalC.ReadOnly = true;
            this.txtBalC.Size = new System.Drawing.Size(209, 38);
            this.txtBalC.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCancel.Location = new System.Drawing.Point(259, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 50);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Done";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 644);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBalC);
            this.Controls.Add(this.txtAccC);
            this.Controls.Add(this.txtBalS);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccS);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAccNum);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtAccS;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBalS;
        private System.Windows.Forms.TextBox txtAccC;
        private System.Windows.Forms.TextBox txtBalC;
        private System.Windows.Forms.Button btnCancel;
    }
}