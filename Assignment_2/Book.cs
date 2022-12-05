using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Book : LibraryLoanItem
    {
        //Loan Period 21 days
        //Max Renewal 4

        
        
        

        

        public Book(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, copies, loanPeriod, maxRenewals)
        {
           
        }

        public override string ToString()
        {
            return "Book " + "\x0A" + base.ToString();
        }

    }
}
