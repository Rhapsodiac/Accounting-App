namespace BigBucksBank
{
    partial class AdminMenu
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
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.rbQuit = new System.Windows.Forms.RadioButton();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.rbUnlock = new System.Windows.Forms.RadioButton();
            this.rbDummy = new System.Windows.Forms.RadioButton();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.BackColor = System.Drawing.Color.Transparent;
            this.rbAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbAdd.Location = new System.Drawing.Point(112, 160);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(201, 39);
            this.rbAdd.TabIndex = 9;
            this.rbAdd.Text = "Add Account";
            this.rbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAdd.UseVisualStyleBackColor = false;
            this.rbAdd.Click += new System.EventHandler(this.rbAdd_Click);
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.BackColor = System.Drawing.Color.Transparent;
            this.rbRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbRemove.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbRemove.Location = new System.Drawing.Point(112, 242);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(247, 39);
            this.rbRemove.TabIndex = 10;
            this.rbRemove.Text = "Remove Account";
            this.rbRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbRemove.UseVisualStyleBackColor = false;
            this.rbRemove.Click += new System.EventHandler(this.rbRemove_Click);
            // 
            // rbQuit
            // 
            this.rbQuit.AutoSize = true;
            this.rbQuit.BackColor = System.Drawing.Color.Transparent;
            this.rbQuit.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbQuit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbQuit.Location = new System.Drawing.Point(112, 399);
            this.rbQuit.Name = "rbQuit";
            this.rbQuit.Size = new System.Drawing.Size(211, 39);
            this.rbQuit.TabIndex = 12;
            this.rbQuit.Text = "Quit Program";
            this.rbQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbQuit.UseVisualStyleBackColor = false;
            this.rbQuit.Click += new System.EventHandler(this.rbQuit_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.rbDummy);
            this.gbMenu.Controls.Add(this.rbDone);
            this.gbMenu.Controls.Add(this.rbUnlock);
            this.gbMenu.Controls.Add(this.rbAdd);
            this.gbMenu.Controls.Add(this.rbQuit);
            this.gbMenu.Controls.Add(this.rbRemove);
            this.gbMenu.Location = new System.Drawing.Point(213, 107);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(459, 520);
            this.gbMenu.TabIndex = 13;
            this.gbMenu.TabStop = false;
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.BackColor = System.Drawing.Color.Transparent;
            this.rbDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbDone.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbDone.Location = new System.Drawing.Point(112, 323);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(102, 39);
            this.rbDone.TabIndex = 14;
            this.rbDone.Text = "Done";
            this.rbDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbDone.UseVisualStyleBackColor = false;
            this.rbDone.Click += new System.EventHandler(this.rbDone_Click);
            // 
            // rbUnlock
            // 
            this.rbUnlock.AutoSize = true;
            this.rbUnlock.BackColor = System.Drawing.Color.Transparent;
            this.rbUnlock.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbUnlock.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.rbUnlock.Location = new System.Drawing.Point(112, 78);
            this.rbUnlock.Name = "rbUnlock";
            this.rbUnlock.Size = new System.Drawing.Size(244, 39);
            this.rbUnlock.TabIndex = 13;
            this.rbUnlock.Text = "Unlock Terminal";
            this.rbUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbUnlock.UseVisualStyleBackColor = false;
            this.rbUnlock.Click += new System.EventHandler(this.rbUnlock_Click);
            // 
            // rbDummy
            // 
            this.rbDummy.AutoSize = true;
            this.rbDummy.BackColor = System.Drawing.Color.Transparent;
            this.rbDummy.Checked = true;
            this.rbDummy.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbDummy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbDummy.Location = new System.Drawing.Point(112, 21);
            this.rbDummy.Name = "rbDummy";
            this.rbDummy.Size = new System.Drawing.Size(91, 27);
            this.rbDummy.TabIndex = 16;
            this.rbDummy.TabStop = true;
            this.rbDummy.Text = "dummy";
            this.rbDummy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbDummy.UseVisualStyleBackColor = false;
            this.rbDummy.Visible = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 725);
            this.Controls.Add(this.gbMenu);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.Resize += new System.EventHandler(this.AdminMenu_Resize);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.RadioButton rbQuit;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.RadioButton rbUnlock;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.RadioButton rbDummy;
    }
}