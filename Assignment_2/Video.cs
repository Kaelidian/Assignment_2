using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Video : LibraryLoanItem
    {
        int loanPeriod;
        int maxRenew;
        int renewals;
        
        public Video(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, copies, loanPeriod, maxRenewals)
        {
            this.loanPeriod = 7;
            this.maxRenew = 1;
            this.renewals = 0;
        }

        public override bool Renew()
        {
            if (renewals < maxRenew)
            {
                renewals++;
                return base.Renew();
            }
            else { return false; }
            
        }
    }
}
