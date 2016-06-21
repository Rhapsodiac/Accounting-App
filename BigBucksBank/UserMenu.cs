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
    public partial class UserMenu : Form
    {
        private AccountList localList;
        int index;

        public UserMenu(AccountList passedAcc, int i)
        {
            InitializeComponent();
            this.localList = passedAcc;
            this.index = i;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.LightSeaGreen, Color.AliceBlue, 135F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void UserMenu_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public AccountList UpdateAccounts()
        {
            this.ShowDialog();
            return localList;
        }
        private void rbWithdraw_Click(object sender, EventArgs e)
        {
            
            UserControl newForm = new UserControl(localList, index, "Withdraw");
            this.localList = newForm.UpdateAccountList();
        }

        private void rbDeposit_Click(object sender, EventArgs e)
        {
            UserControl newForm = new UserControl(localList, index,"Deposit");
            this.localList = newForm.UpdateAccountList();
        }

        private void rbBalance_Click(object sender, EventArgs e)
        {
            UserControl newForm = new UserControl(localList, index,"Balance");
            this.localList = newForm.UpdateAccountList();
        }

        private void rbTransfer_Click(object sender, EventArgs e)
        {
            UserControl newForm = new UserControl(localList, index, "Transfer");
            this.localList = newForm.UpdateAccountList();
        }

        private void rbDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
