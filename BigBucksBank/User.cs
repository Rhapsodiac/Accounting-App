using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class User : Account
    {
        private string checkNum;
        private string savNum;
        private decimal balC, balS;

        public User(string userN, string pW, string chAcc, string savAcc,
           decimal balC = 0, decimal balS = 0) : base(userN, pW)
        {
            this.checkNum = chAcc;
            this.savNum = savAcc;
            this.balC = balC;
            this.balS = balS;
            base.SecState = base.UserState;
        }

        public string CheckNum
        {
            get
            {
                return checkNum;
            }
            set
            {
                checkNum = value;
            }
        }

        public string SavNum
        {
            get
            {
                return savNum;
            }
            set
            {
                savNum = value;
            }
        }

        public decimal BalanceC
        {
            get
            {
                return balC;
            }
            set
            {
                balC = value;
            }
        }
        public decimal BalanceS
        {
            get
            {
                return balS;
            }
            set
            {
                balS = value;
            }
        }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + sep + CheckNum + sep + SavNum + sep + BalanceC
                + sep + BalanceS;
        }

        public string GetChAcc()
        {
            string temp = "****";
            for (int c = CheckNum.Length / 2; c < CheckNum.Length; c++)
            {
                temp += CheckNum[c];
            }
            return temp;
        }

        public string GetSavAcc()
        {
            string temp = "****";
            for (int c = SavNum.Length / 2; c < SavNum.Length; c++)
            {
                temp += SavNum[c];
            }
            return temp;
        }
    }
}
