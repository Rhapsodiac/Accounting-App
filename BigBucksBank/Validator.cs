using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsDecimal(TextBox box)
        {
            decimal number = 0m;
            if (Decimal.TryParse(box.Text, out number))
            {
                return true;
            }
            return false;
        }

        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("This entry is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPosDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number) && number >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("This entry must be a decimal value of at least zero.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show("This entry must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool FieldsValid(TextBox box1, TextBox box2)
        {
            if(IsPresent(box1) && IsPosDecimal(box2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool FieldsValid(TextBox box1, TextBox box2, TextBox box3)
        {
            if (IsPresent(box1) && IsPresent(box2) && IsPosDecimal(box3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static decimal GetDecimal(TextBox box)
        {
            return Convert.ToDecimal(box.Text);
        }

        public static bool FirstIsLetter(TextBox box)
        {
            char c = (char)box.Text[0];
            return Char.IsLetter(c);
        }

        public static bool CheckId(TextBox box)
        {
            if (!Validator.FirstIsLetter(box))
            {
                MessageBox.Show("This entry is an incorrect.");
                box.Focus();
                return false;
            }
            return true;
        }

        public static bool CheckAcc(TextBox box)
        {
            if (IsPresent(box))
            {
                char[] arr = box.Text.ToCharArray();
                foreach(char c in arr){
                    if((c-48) < 0 || (c - 48) > 9)
                    {
                        MessageBox.Show("This entry is an incorrect.");
                        box.Focus();
                        return false;
                    }

                }
                return true;
            }
            return false;               
        }
    }
}
