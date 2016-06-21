using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class Receipt : Form
    {
        User temp;
        decimal amount;

        public Receipt(User userAcc, decimal amount)
        {
            InitializeComponent();
            this.temp = userAcc;
            this.amount = amount;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            txtUserID.Text = (temp as Account).UserName;
            txtAccC.Text = temp.GetChAcc();
            txtAccS.Text = temp.GetSavAcc();
            txtAmount.Text = amount.ToString("c");
            txtBalC.Text = temp.BalanceC.ToString("c");
            txtBalS.Text = temp.BalanceS.ToString("c");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
