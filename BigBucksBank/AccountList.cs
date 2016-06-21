using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class AccountList : List<Account>
    {
        const int NUM_ACCOUNTS = 7;
        const int SIZE_PIN = 4;
        const int SIZE_ACC_NUM = 8;
        string[] arrNames = { "bobross", "marylamb", "geogarmani", "bibinetanyahu", "johnoliver", "eriklensherr", "admin" };
        private Random ranNum;

        public AccountList()
        {
            ranNum = new Random();
        }
        
        public void genAccounts()
        {
            int j = 0;                        
            for (int c = 0; c < NUM_ACCOUNTS; c++, j++)
            {
                if (j == NUM_ACCOUNTS-1)
                    base.Add(new Admin(genName(c), "0000"));
                else
                    base.Add(new User(genName(c), genPIN(), genAccNum(true), genAccNum(false), genBal(), genBal()));
            }
        }

        private string genName(int c)
        {
            return arrNames[c];
        }

        public int FindUserAccount(string accNum)
        {
            int ind2 = -1;
            User temp;
            for(int c = 0; c < this.Count && this[c].SecState != "admin"; c++)
            {
                temp = (User)this[c];
                if(accNum.Equals(temp.SavNum) || ((accNum.Equals(temp.CheckNum))))
                {
                    ind2 = c;
                }
            }
            return ind2;
        }

        public bool UserSavOrCheck(string accNum)
        {
           bool checking = false;
            User temp;
            for (int c = 0; c < this.Count && this[c].SecState != "admin"; c++)
            {
                temp = (User)this[c];
                if (accNum.Equals(temp.SavNum))
                {
                    checking = false;
                }
                else if (accNum.Equals(temp.CheckNum))
                {
                    checking = true;
                }
            }
            return checking;
        }

        private string genPIN()
        {
            string pin = "";
            for (int c = 0; c < SIZE_PIN; c++)
            {
                pin += ranNum.Next(9).ToString();
            }
            return pin;
        }

        private string genAccNum(bool check)
        {
            string acc = "";
            for (int c = 0; c < SIZE_ACC_NUM; c++)
            {
                acc += ranNum.Next(9).ToString();
            }
            return acc;
        }

        private decimal genBal()
        {
            int rich = ranNum.Next(1);
            if (rich == 0)
                return (decimal)ranNum.Next(11772); //Mass poverty line
            else
                return (decimal)ranNum.Next(11773, 120000);
        }



    }
}
