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
    public partial class UserControl : Form
    {
        AccountList localList;
        string control;
        int index;

        //DEBUG IF YOU WANT TO WRITE TO CONSOLE FOR EASIER GRADING
        //PLACE BEFORE/AFTER ANY ACTIONS TO SEE EFFECTS
        /*
        Console.Write(temp.UserName + "\t" + temp.CheckNum + "\t" + temp.SavNum +
                           "\n" + temp.BalanceC + "\t" + temp.BalanceS);
                    Console.Write((localList[ind2] as User).UserName + "\t" + (localList[ind2] as User).CheckNum + "\t" + (localList[ind2] as User).SavNum +
                           "\n" + (localList[ind2] as User).BalanceC + "\t" + (localList[ind2] as User).BalanceS);

        */

        public UserControl(AccountList passed,int i, string control)
        {
            InitializeComponent();
            this.localList = passed;
            this.control = control;
            this.index = i;
        }

        public AccountList UpdateAccountList()
        {
            this.ShowDialog();
            return localList;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            bool checking = rbChecking.Checked;
            bool success = true;
            
            switch (control)
            {
                //left for other controls
                case "Withdraw":
                    if (Validator.FieldsValid(txtAccNum, txtAmount))
                    {
                        if (!Withdraw(txtAccNum.Text, Validator.GetDecimal(txtAmount), checking))
                        {
                            MessageBox.Show("Insufficient Balance or Incorrect Account");
                            success = false;
                        }                        
                    }                    
                    break;
                case "Deposit":
                    if (Validator.FieldsValid(txtAccNum, txtAmount))
                    {
                        if (!Deposit(txtAccNum.Text, Validator.GetDecimal(txtAmount), checking))
                        {
                            MessageBox.Show("Incorrect Account.");
                            success = false;
                        }
                    }
                    break;                    
                    case "Balance":
                    if (Validator.IsPresent(txtAccNum))
                    {
                        decimal bal;
                        if ((bal = Balance(txtAccNum.Text, checking)) != -1)
                        {
                            MessageBox.Show("Your " + (checking? "checking ": "savings ") + "balance is " +bal.ToString("c"), "CURRENT BALANCE");
                        }
                        else
                        {
                             MessageBox.Show("Incorrect Account.");
                            success = false;
                        }
                    }
                    break;
                    case "Transfer":
                    if(Validator.FieldsValid(txtAccNum, txtRecAccNum, txtAmount))
                    {
                      if (!Transfer(txtAccNum.Text, txtRecAccNum.Text, Validator.GetDecimal(txtAmount), checking))
                        {
                            MessageBox.Show("Insufficient Balance or Incorrect Account");
                            success = false;
                        }
                    }
                    break;                  
                default:
                    success = false;
                    break;
            }
            if (success)
            {
                Receipt newForm = new Receipt((localList[index] as User), Validator.IsDecimal(txtAmount) ? Validator.GetDecimal(txtAmount): 0m);
                newForm.Show();
            }
            
            
        }

        private void setVis(string control)
        {
            switch (control)
            {
                case "Withdraw":
                case "Deposit":
                    txtAmount.Show();
                    txtAccNum.Show();
                    lblAmount.Show();
                    lblAccNum.Show();
                    lblRecAccNum.Hide();
                    txtRecAccNum.Hide();
                    break;
                case "Balance":
                    txtAccNum.Show();
                    lblAccNum.Show();
                    lblRecAccNum.Hide();
                    txtRecAccNum.Hide();
                    lblAmount.Hide();
                    txtAmount.Hide();
                    break;
                case "Transfer":
                    txtAmount.Show();
                    txtAccNum.Show();
                    lblAmount.Show();
                    lblAccNum.Show();
                    lblRecAccNum.Show();
                    txtRecAccNum.Show();
                    break;
                default: break;
            }
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            btnControl.Text = control;
            setVis(control);
            lblRecAccNum.MaximumSize = new Size(220, 0);
            lblControl.Text = control;
        }

        private bool Withdraw(string Acc, decimal amount, bool checking)
        {
            if (checking && (localList[index] as User).CheckNum.Equals(Acc))
            {
                if (LessThanZero((localList[index] as User).BalanceC, amount))
                    return false;
                else
                {
                   (localList[index] as User).BalanceC -= amount;
                    return true;
                }
            }
            else if (!checking && (localList[index] as User).SavNum.Equals(Acc))
            {
                if (LessThanZero((localList[index] as User).BalanceS, amount))
                    return false;
                else
                {
                    (localList[index] as User).BalanceS -= amount;
                    return true;
                }
            }
            else
                return false;
        }

        private bool Deposit(string Acc, decimal amount, bool checking)
        {
           
            if (checking && (localList[index] as User).CheckNum.Equals(Acc))
            {
                (localList[index] as User).BalanceC += amount;
                return true;

            }
            else if (!checking && (localList[index] as User).SavNum.Equals(Acc))
            {
                (localList[index] as User).BalanceS += amount;
                    return true;                
            }
            else
                return false;
        }

        private decimal Balance(string Acc, bool checking)
        {
            if (checking && (localList[index] as User).CheckNum.Equals(Acc))
            {
                return (localList[index] as User).BalanceC;
            }
            else if (!checking && (localList[index] as User).SavNum.Equals(Acc))
            {
                return (localList[index] as User).BalanceS;
            }
            else
                return -1;
        }

        private bool Transfer(string AccFrom, string AccTo, decimal amount, bool checking)
        {
            int ind2 = -1;

            if (checking && (localList[index] as User).CheckNum.Equals(AccFrom) && (ind2 = localList.FindUserAccount(AccTo)) != -1)
            {
                if (LessThanZero((localList[index] as User).BalanceC, amount))
                {
                    return false;
                }
                else
                {
                    (localList[index] as User).BalanceC -= amount;

                    if (localList.UserSavOrCheck(AccTo))
                    {
                        (localList[ind2] as User).BalanceC += amount;
                    }
                    else
                    {
                        (localList[ind2] as User).BalanceS += amount;
                    }
                    return true;
                }
            }
            else if (!checking && (localList[index] as User).SavNum.Equals(AccFrom) && (ind2 = localList.FindUserAccount(AccTo)) != -1)
            {
                if (LessThanZero((localList[index] as User).BalanceS, amount))
                {
                    return false;
                }
                else
                {
                    (localList[index] as User).BalanceS -= amount;

                    if (localList.UserSavOrCheck(AccTo))
                    {
                        (localList[ind2] as User).BalanceC += amount;
                    }
                    else
                    {
                        (localList[ind2] as User).BalanceS += amount;
                    }
                    return true;
                }
            }
            return false;
        }

        private bool LessThanZero(decimal bal, decimal am)
        {
            if ((bal - am) < 0)
                return true;
            else
                return false;
        }
    }
}
