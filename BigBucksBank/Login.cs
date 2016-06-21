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
    public partial class Login : Form
    {

        private AccountList accounts = new AccountList();
        private static int logCounter = 1;
        private bool locked = false;

        public Login()
        {
            InitializeComponent();
        }        

        private void Login_Load(object sender, EventArgs e)
        {
            accounts.genAccounts();           
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.AliceBlue,Color.LightSeaGreen, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        
        private void Login_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pin = txtPIN.Text;
            int i = 0;
            lbDisplay.Items.Clear();
            Account temp = new Account(name, pin);            
            if (logCounter > 2 && locked == false)
            {
                locked = true;
                logCounter = 1;
                lbDisplay.Items.Add("Too many incorrect logins, terminal is locked. Log in with Admin to continue.");
            }
            else {
                if ((i = accounts.IndexOf(temp)) != -1)               
                {
                    if (accounts[i].SecState == "admin")
                    {
                        AdminMenu newForm = new AdminMenu(accounts, locked);
                        accounts = newForm.UpdateAccountList();
                        locked = newForm.Locked;
                    }
                    else if(accounts[i].SecState == "user" && locked == true)
                    {
                        lbDisplay.Items.Add("Unable to log in with User Account while terminal is locked. Log in with Admin account to continue.");
                    }
                    else if(accounts[i].SecState == "user")
                    {
                        UserMenu newForm = new UserMenu(accounts, i);
                        accounts = newForm.UpdateAccounts();
                    }
                }
                else if (locked)
                {
                    lbDisplay.Items.Add("Terminal Locked.");                        
                }
                else
                {
                    logCounter++;
                    lbDisplay.Items.Add("Account not found.");
                }
            }            
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            //DEBUG CODE FOR GRADING PURPOSES
            lbDisplay.Items.Add("DEBUG\n");
            lbDisplay.Items.Add("Terminal Is Locked? " + locked + "\n");
            lbDisplay.Items.Add(accounts.Count().ToString() + " accounts on file.\n");
            lbDisplay.Items.Add("UserID\tPIN\tAccountType\tChecking\tSaving\tBalanceC\tBalanceS\n");
            for (int c = 0; c < accounts.Count(); c++)
            {
                lbDisplay.Items.Add(accounts[c].GetDisplayText("\t"));
            }
            //END DEBUG CODE FOR GRADING PURPOSES
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPIN.Clear();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        private void txtPIN_Enter(object sender, EventArgs e)
        {
            txtPIN.SelectAll();
        }
    }
}
