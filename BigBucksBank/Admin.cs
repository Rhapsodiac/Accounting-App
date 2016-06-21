using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class Admin : Account
    {

        public Admin(string userN, string pW) : base(userN, pW)
        {
            base.SecState = base.AdminState;
        }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep);
        }
    }

}
