using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BigBucksBank
{
    public partial class AdminMenu : Form
    {
        private AccountList localList;
        private bool termLocked;

        public AdminMenu(AccountList passedAcc, bool locked)
        {
            InitializeComponent();
            this.localList = passedAcc;
            this.termLocked = locked;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.LightSeaGreen, Color.AliceBlue, 135F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void AdminMenu_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public AccountList UpdateAccountList()
        {
            this.ShowDialog();
            return localList;
        }

        public bool Locked
        {
            get
            {
                return termLocked;
            }
        }

        private void rbAdd_Click(object sender, EventArgs e)
        {
            AdminAddAccount newForm = new AdminAddAccount(localList);
            this.localList = newForm.UpdateAccountList();
        }

        private void rbRemove_Click(object sender, EventArgs e)
        {
            AdminControl newForm = new AdminControl(localList, "Remove");
            localList = newForm.UpdateAccountList();
        }

        private void rbDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbQuit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to quit?";
            DialogResult button = MessageBox.Show(message, "Confirm Quit", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
           

        }

        private void rbUnlock_Click(object sender, EventArgs e)
        {
            termLocked = false;
        }
    }
}
