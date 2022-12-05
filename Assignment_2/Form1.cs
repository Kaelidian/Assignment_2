using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public List<LibraryLoanItem> loanList;
        AddItemForm addItemForm;
        public Form1()
        {
            InitializeComponent();
            loanList = new List<LibraryLoanItem>();
        }

        private void addLoanItemButton_Click(object sender, EventArgs e)
        {
            addItemForm = new AddItemForm(ref loanList);
            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                collectionListBox.Items.Clear();
                foreach(LibraryLoanItem item in loanList)
                {
                    collectionListBox.Items.Add(item.ToString('s')) ;
                }
                
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            string callNum;

            if (callNumberTextBox.Text.Length == 7)
            {
                callNum = callNumberTextBox.Text;
                int copyId = -1;
                
                for (int i = 0; i < loanList.Count; i++)
                {
                    if (loanList[i].CallNumber == callNum)
                    {
                        copyId = loanList[i].CheckOut(callNum);
                        if(copyId != -1)
                        {
                            confirmationListBox.Items.Add("Successfully checked out " + loanList[i].ToString());
                            confirmationListBox.Items.Add("Copy ID: " + copyId);
                        }
                        else
                        {
                            confirmationListBox.Items.Add("No Remaining Copies of " + loanList[i].ToString('s'));

                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Incorrect length.");
            }
            

        }
        private void updateCollectionListbox()
        {
            collectionListBox.Items.Clear();
            foreach (LibraryLoanItem item in loanList)
            {
                collectionListBox.Items.Add(item.ToString('s'));
            }
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            string callNum;
            int copyId = -1;

            if (callNumberTextBox.Text.Length == 7)
            {
                callNum = callNumberTextBox.Text;

                if(int.TryParse(copyIDTextBox.Text.Trim(), out copyId))
                {
                    for (int i = 0; i < loanList.Count; i++)
                    {
                        if (loanList[i].CallNumber == callNum)
                        {

                            if (loanList[i].CheckIn(callNum, copyId))
                            {
                                confirmationListBox.Items.Add("Successfully checked in " + loanList[i].ToString());
                                confirmationListBox.Items.Add("Copy ID: " + copyId);
                            }
                            else
                            {
                                confirmationListBox.Items.Add("No Remaining Copies of " + loanList[i].ToString('s'));

                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect length.");
            }

        }

        private void renewButton_Click(object sender, EventArgs e)
        {
            string callNum;
            int copyId = -1;

            if (callNumberTextBox.Text.Length == 7)
            {
                callNum = callNumberTextBox.Text;
                
                
                if (int.TryParse(copyIDTextBox.Text.Trim(), out copyId))
                {
                    for (int i = 0; i < loanList.Count; i++)
                    {
                        if (loanList[i].CallNumber == callNum)
                        {

                            if (loanList[i].Renew(callNum, copyId))
                            {
                                confirmationListBox.Items.Add("Successfully Renewed " + loanList[i].ToString());
                                confirmationListBox.Items.Add("Copy ID: " + copyId + " Renewals: " + loanList[i].TimesRenewed[i] + "/" + loanList[i].MaxRenewals);
                            }
                            else
                            {
                                confirmationListBox.Items.Add("Not successful");

                            }

                        }
                    }
                }
                    

            }
            else
            {
                MessageBox.Show("Incorrect length.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchInput = searchInputTextBox.Text.Trim();
            if(sbAuthorRadioButton.Checked == true)
            {
                if(loanList.Count > 0)
                {
                    for (int i = 0; i < loanList.Count; i++)
                    {
                        if (loanList[i].Author == searchInput)
                        {
                            searchOutputListBox.Items.Add(loanList[i].ToString('s'));
                        }
                    }
                }
                
            }else if(sbTitleRadioButton.Checked == true)
            {
                if (loanList.Count > 0)
                {
                    for (int i = 0; i < loanList.Count; i++)
                    {
                        if (loanList[i].Title == searchInput)
                        {
                            searchOutputListBox.Items.Add(loanList[i].ToString('s'));
                        }
                    }
                }
            }
        }
    }
}
