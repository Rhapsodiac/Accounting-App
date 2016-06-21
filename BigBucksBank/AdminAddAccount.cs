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
    public partial class AdminAddAccount : Form
    {
        AccountList localList;
        private bool admin;

        public AdminAddAccount(AccountList passed)
        {
            InitializeComponent();
            this.localList = passed;
        }

        private void AdminAddAccount_Load(object sender, EventArgs e)
        {
            admin = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator.CheckId(txtID) && Validator.CheckAcc(txtCheck) && Validator.CheckAcc(txtSav)){
                Account temp;
                if (admin)
                {
                    temp = new Admin(txtID.Text, txtPIN.Text);
                }
                else
                {
                    temp = new User(txtID.Text, txtPIN.Text, txtCheck.Text, txtSav.Text, Convert.ToDecimal((txtBalC.Text)), Convert.ToDecimal((txtBalS.Text)));
                }
                localList.Add(temp);
                this.Close();
            }
        }

        public AccountList UpdateAccountList()
        {
            this.ShowDialog();
            return localList;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                admin = true;
                lblCheckAccNum.Hide();
                lblSavAccNum.Hide();
                lblBalC.Hide();
                lblBalS.Hide();
                txtSav.Hide();
                txtCheck.Hide();
                txtBalC.Hide();
                txtBalS.Hide();
            }
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked)
            {
                admin = false;
                lblCheckAccNum.Show();
                lblSavAccNum.Show();
                lblBalC.Show();
                lblBalS.Show();
                txtSav.Show();
                txtCheck.Show();
                txtBalC.Show();
                txtBalS.Show();
            }
        }
    }
}
