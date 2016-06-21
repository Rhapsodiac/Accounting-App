using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank

{
    public class Account : IEquatable<Account>
    {
        private string userName;
        private string pass; //PIN, 4 digits
        private string secState; //admin or user
        private string userState = "user";
        private string adminState = "admin";

        public Account(string userN, string pW)
        {
            this.userName = userN;
            this.pass = pW;            
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }

        public string SecState
        {
            get
            {
                return secState;
            }
            set
            {
                secState = value;
            }
        }

        public string UserState
        {
            get
            {
                return userState;
            }
        }

        public string AdminState
        {
            get
            {
                return adminState;
            }
        }

        public virtual string GetDisplayText(string sep)
        {
            string s;
            return s = String.Format("{0,-20} {1,-15} {2,5}", UserName, Pass, SecState);
        }

        public bool Equals(Account other)
        {
            if(this.UserName == other.UserName && this.Pass == other.Pass)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
