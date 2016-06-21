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
    public partial class AdminControl : Form
    {
        AccountList local;
        string control;
        public AdminControl(AccountList passed, string control)
        {
            InitializeComponent();
            this.local = passed;
            this.control = control;
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            btnControl.Text = control;
            for (int c = 0; c < local.Count(); c++)
                lbAccounts.Items.Add(local[c].GetDisplayText("\t"));                      
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            switch (control)
            {
                //left for other controls
                case "Remove":if(local[lbAccounts.SelectedIndex].SecState != "admin")
                    local.Remove((Account)local[lbAccounts.SelectedIndex]);
                    else
                    {
                        string message = "Cannot remove Admin Accounts";
                        DialogResult button =
                            MessageBox.Show(message, "Error",
                            MessageBoxButtons.OK);
                    }
                    break;
                default: break;
            }
            lbAccounts.Items.Clear();
            for (int c = 0; c < local.Count(); c++)
                lbAccounts.Items.Add(local[c].GetDisplayText("\t"));
        }

        public AccountList UpdateAccountList()
        {
            return local;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
