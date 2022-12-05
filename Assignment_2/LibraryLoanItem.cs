using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public abstract class LibraryLoanItem
    {
        
        public List<LibraryLoanItem> _loanItems = new List<LibraryLoanItem>();


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
            if (callNumber.Length == 7)
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
                                        this._timesRenewed[i] = -1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        public string CallNumber { get { return _callNumber; } }
        public string Title { get { return _title; } }
        public string Author { get { return _author; } }
        public int Copies { get { return _copies; } }
        public int AvailableCopies { get { return _availableCopies; } }
        public int LoanPeriod { get { return _loanPeriod; } }
        public int MaxRenewals { get { return _maxRenewals; } }

        public int[] TimesRenewed { get { return _timesRenewed; } }

        public int CheckOut(string callNumber )
        {
            int copy = 0;

            if (callNumber.Length == 7)
            {
                
                    if (this.AvailableCopies >= 1)
                    {
                        copy = Copies - AvailableCopies;

                        _timesRenewed[copy] = 0;
                        _availableCopies -= 1;
                    }
                
                
                
            }else { MessageBox.Show("Call Number invalid."); }
            return copy;
            
        }

        public bool CheckIn(string callNumber, int copyId)
        {
            bool completed = false;
            
            if(AvailableCopies < Copies)
            {
                _availableCopies++;
                completed = true;
            }

            return completed;




        }

        public virtual bool Renew(string callNumber, int copyId)
        {
            //Used to renew a specific copy of this item
            bool completed = false;

            if (_timesRenewed[copyId] < MaxRenewals)
            {
                _timesRenewed[copyId] += 1;
                completed = true;
            }
            
            return completed;

        }

        public string ToString(char a)
        {
            string simpleString = "";
            if (a == 's')
            {
                simpleString = "Call #" + CallNumber + " Title: " + Title + " Author: " + Author;
            }
            return simpleString;
        }
        public override string ToString()
        {
            //(include call number, title, author, loan period, number of copies, and available copies in the String representation)
            string libLoanItemString = "";

            libLoanItemString = "Call #: " + CallNumber + " Title: " + Title + " Author: " + Author + "\x0A" +
                               " Loan Period: " + LoanPeriod + " Copies: " + AvailableCopies + "/" + Copies;


            return libLoanItemString;
        }

        
        
    }

        

}

