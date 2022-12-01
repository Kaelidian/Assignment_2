using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class DVD : LibraryLoanItem
    {
        public DVD(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, copies, loanPeriod, maxRenewals)
        {

        }

        public override bool Renew()
        {
            //Not Renewable
            return false;
        }
    }
}
