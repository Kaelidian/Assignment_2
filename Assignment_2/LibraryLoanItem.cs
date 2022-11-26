using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class LibraryLoanItem
    {
        protected string _callNumber; // Format "100 GAD"
        protected string _title;
        protected string _author;
        protected int _copies;
        protected int _availableCopies;
        protected int _loanPeriod;
        protected int _maxRenewals;
        protected int[] _timesRenewed;

        public LibraryLoanItem(string callNumber, string title, string author, int copies, int loanPeriod, int maxRenewals)
        {
            if (callNumber.Length > 0 && callNumber.Length < 7)
            {
                this._callNumber = callNumber;
                if (title.Length > 0)
                {
                    this._title = title;
                    if (author.Length > 0)
                    {
                        this._author = author;
                        if (copies > 0)
                        {
                            this._copies = copies;
                            if (loanPeriod > 0 && loanPeriod == 7 || loanPeriod == 21)
                            {
                                this._loanPeriod = loanPeriod;
                                if (maxRenewals >= 0)
                                {

                                    this._maxRenewals = maxRenewals;
                                    this._availableCopies = copies;
                                    this._timesRenewed = new int[copies];
                                    for(int i = 0; i < copies; i++)
                                    {
                                        this._timesRenewed[i] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public string CallNumber
        {
            get { return _callNumber; }
        }
        public string Title { get { return _title; } }
        public string Author { get { return _author; } }
        public int Copies { get { return _copies; } }
        public int AvailableCopies { get { return _availableCopies; } }
        public int LoanPeriod { get { return _loanPeriod; } }
        public int MaxRenewals { get { return _maxRenewals; } }

        public int[] TimesRenewed { get { return _timesRenewed; } }

        public int CheckOut()
        {
            if (this.AvailableCopies >= 1)
            {
                return (Copies);
            }
            else return -1;
        }

        public bool CheckIn()
        {
            return true;

        }

        public virtual bool Renew()
        {
            return false;


        }

        public override string ToString()
        {
            //(include call number, title, author, loan period, number of copies, and available copies in the String representation)
            string libLoanItemString = "";

            libLoanItemString = this.CallNumber + " Title: " + this.Title + " Author: " + this.Author +
                                " Loan Period: " + this.LoanPeriod + " Copies: " + this.AvailableCopies + "/" + this.Copies;

            return libLoanItemString;
        }
    }
}
