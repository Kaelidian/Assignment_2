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

        protected string ISBN;
        

        public Book(string callNumber, string title, string author, string ISBN, int copies, int loanPeriod, int maxRenewals) : base(callNumber, title, author, copies, loanPeriod, maxRenewals)
        {
            if (isValidISBN(ISBN))
            {
                this.ISBN = ISBN;
            }

        }
        static bool isValidISBN(string isbn)
        {
            // length must be 10
            int n = isbn.Length;
            if (n != 10)
                return false;

            // Computing weighted sum of
            // first 9 digits
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = isbn[i] - '0';

                if (0 > digit || 9 < digit)
                    return false;

                sum += (digit * (10 - i));
            }

            // Checking last digit.
            char last = isbn[9];
            if (last != 'X' && (last < '0'
                             || last > '9'))
                return false;

            // If last digit is 'X', add 10
            // to sum, else add its value.
            sum += ((last == 'X') ? 10 :
                              (last - '0'));

            // Return true if weighted sum
            // of digits is divisible by 11.
            return (sum % 11 == 0);
        }
        
    }
}
