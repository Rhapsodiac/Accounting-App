namespace BigBucksBank
{
    partial class UserMenu
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
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.rbDummy = new System.Windows.Forms.RadioButton();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.BackColor = System.Drawing.Color.Transparent;
            this.rbDeposit.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbDeposit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbDeposit.Location = new System.Drawing.Point(91, 156);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(236, 39);
            this.rbDeposit.TabIndex = 8;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Make A Deposit";
            this.rbDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbDeposit.UseVisualStyleBackColor = false;
            this.rbDeposit.Click += new System.EventHandler(this.rbDeposit_Click);
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.rbWithdraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbWithdraw.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbWithdraw.Location = new System.Drawing.Point(91, 88);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(285, 39);
            this.rbWithdraw.TabIndex = 9;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Make A Withdrawal";
            this.rbWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbWithdraw.UseVisualStyleBackColor = false;
            this.rbWithdraw.Click += new System.EventHandler(this.rbWithdraw_Click);
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.BackColor = System.Drawing.Color.Transparent;
            this.rbBalance.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbBalance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbBalance.Location = new System.Drawing.Point(91, 228);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(222, 39);
            this.rbBalance.TabIndex = 10;
            this.rbBalance.TabStop = true;
            this.rbBalance.Text = "Check Balance";
            this.rbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBalance.UseVisualStyleBackColor = false;
            this.rbBalance.Click += new System.EventHandler(this.rbBalance_Click);
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.BackColor = System.Drawing.Color.Transparent;
            this.rbTransfer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbTransfer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbTransfer.Location = new System.Drawing.Point(91, 295);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(230, 39);
            this.rbTransfer.TabIndex = 11;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer Funds";
            this.rbTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTransfer.UseVisualStyleBackColor = false;
            this.rbTransfer.Click += new System.EventHandler(this.rbTransfer_Click);
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.BackColor = System.Drawing.Color.Transparent;
            this.rbDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbDone.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbDone.Location = new System.Drawing.Point(91, 367);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(102, 39);
            this.rbDone.TabIndex = 12;
            this.rbDone.TabStop = true;
            this.rbDone.Text = "Done";
            this.rbDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbDone.UseVisualStyleBackColor = false;
            this.rbDone.Click += new System.EventHandler(this.rbDone_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.rbDummy);
            this.gbMenu.Controls.Add(this.rbDeposit);
            this.gbMenu.Controls.Add(this.rbDone);
            this.gbMenu.Controls.Add(this.rbWithdraw);
            this.gbMenu.Controls.Add(this.rbTransfer);
            this.gbMenu.Controls.Add(this.rbBalance);
            this.gbMenu.Location = new System.Drawing.Point(213, 113);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(456, 464);
            this.gbMenu.TabIndex = 13;
            this.gbMenu.TabStop = false;
            // 
            // rbDummy
            // 
            this.rbDummy.AutoSize = true;
            this.rbDummy.BackColor = System.Drawing.Color.Transparent;
            this.rbDummy.Checked = true;
            this.rbDummy.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbDummy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbDummy.Location = new System.Drawing.Point(91, 21);
            this.rbDummy.Name = "rbDummy";
            this.rbDummy.Size = new System.Drawing.Size(91, 27);
            this.rbDummy.TabIndex = 17;
            this.rbDummy.TabStop = true;
            this.rbDummy.Text = "dummy";
            this.rbDummy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbDummy.UseVisualStyleBackColor = false;
            this.rbDummy.Visible = false;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 782);
            this.Controls.Add(this.gbMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.Resize += new System.EventHandler(this.UserMenu_Resize);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.RadioButton rbDummy;
    }
}