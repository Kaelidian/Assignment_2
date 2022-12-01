using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class NewBook : Book
    {
        public NewBook(string callNumber, string title, string author, string ISBN, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, ISBN, copies, loanPeriod, maxRenewals)
        {

        }

        public override bool Renew()
        {
            //No renewals on new books
            return false;
        }
    }
}
