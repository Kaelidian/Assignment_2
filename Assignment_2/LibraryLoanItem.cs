using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class LibraryLoanItem
    {
        protected string callNumber; // Format "100 GAD"
        protected string title;
        protected string author;
        protected int copies;
        protected int availableCopies;
        protected int loanPeriod;
        protected int maxRenewals;
        protected int timesRenewed;

        public LibraryLoanItem(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals)
        {


            this.callNumber = callNumber;
            this.title = title;
            this.author = author;
            this.copies = copies;
            this.loanPeriod = loanPeriod;
            this.maxRenewals = maxRenewals;
        
        }
    }
}
