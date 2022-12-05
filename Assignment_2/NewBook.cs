using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class NewBook : LibraryLoanItem
    {
        public NewBook(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, copies, loanPeriod, maxRenewals)
        {

        }

        public override string ToString()
        {
            return "New Book " + base.ToString();
        }

        public override bool Renew(string callNumber, int copyId)
        {
            return false;
        }
    }
}
