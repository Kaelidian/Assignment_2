using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class CD : LibraryLoanItem
    {
        public CD(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, copies, loanPeriod, maxRenewals)
        {
        }

        public override string ToString()
        {
            return "CD " + base.ToString();
        }
    }
}
