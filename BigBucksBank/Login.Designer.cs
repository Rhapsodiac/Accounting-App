namespace BigBucksBank
{
    partial class Login
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
            this.btnClear = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(884, 632);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 52);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(530, 53);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(351, 46);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Big Bucks Bank!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.Transparent;
            this.lblUserId.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(457, 160);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(203, 35);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "Enter User ID:";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDisplay.Location = new System.Drawing.Point(695, 356);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(61, 19);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "Display";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLogin.Location = new System.Drawing.Point(463, 632);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtName.Location = new System.Drawing.Point(753, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 38);
            this.txtName.TabIndex = 7;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.BackColor = System.Drawing.Color.Transparent;
            this.lblPIN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIN.Location = new System.Drawing.Point(457, 233);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(156, 35);
            this.lblPIN.TabIndex = 10;
            this.lblPIN.Text = "Enter PIN:";
            this.lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtPIN.Location = new System.Drawing.Point(753, 230);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(237, 38);
            this.txtPIN.TabIndex = 11;
            this.txtPIN.Enter += new System.EventHandler(this.txtPIN_Enter);
            // 
            // lbDisplay
            // 
            this.lbDisplay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 22;
            this.lbDisplay.Location = new System.Drawing.Point(274, 394);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(930, 114);
            this.lbDisplay.TabIndex = 12;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(127, 160);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(127, 78);
            this.btnDebug.TabIndex = 13;
            this.btnDebug.Text = "To list Accounts for Grading Purposes, Click Me!";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1473, 770);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Button btnDebug;
    }
}

