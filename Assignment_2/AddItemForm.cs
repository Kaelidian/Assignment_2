using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_2.LibraryLoanItem;

namespace Assignment_2
{
    
    public partial class AddItemForm : Form
    {
        public List<LibraryLoanItem> items;
        
        public AddItemForm(ref List<LibraryLoanItem> loanItems)
        {
            InitializeComponent();
            items = loanItems;
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            bookRadioButton.Checked = true;
            fourRenewalRadioButton.Checked = true;
            loan7RadioButton.Checked = true;
            callNumTextBox.Text = "";
            titleTextBox.Text = "";
            authorTextBox.Text = "";
            copiesTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            LibraryLoanItem mockItem;

            string callNumber = "";
            string title = "";
            string author = "";
            int copies = -1;
            int loanPeriod = loan7RadioButton.Checked ? 7 : 21;
            int maxRenewals = zeroRenewalRadioButton.Checked ? 0 : (oneRenewalRadioButton.Checked ? 1 : (twoRenewalRadioButton.Checked ? 2 : (fourRenewalRadioButton.Checked ? 4 : 0)));


            if (callNumTextBox.Text.Length == 7)
            {
                callNumber = callNumTextBox.Text;
                if (titleTextBox.Text.Length > 0)
                {
                    title = titleTextBox.Text;
                    if (authorTextBox.Text.Length > 0)
                    {
                        author = authorTextBox.Text;
                        if (int.TryParse(copiesTextBox.Text.Trim(), out copies))
                        {
                            if (copies > 0)
                            {
                                if (bookRadioButton.Checked == true)
                                {
                                    mockItem = new Book(callNumber, title, author, copies, loanPeriod, maxRenewals);
                                    MessageBox.Show(mockItem.ToString());
                                    items.Add(mockItem);

                                }
                                if (cdRadioButton.Checked == true)
                                {
                                    mockItem = new CD(callNumber, title, author, copies, loanPeriod, maxRenewals);
                                    MessageBox.Show(mockItem.ToString());
                                    items.Add(mockItem);
                                }
                                if (videoRadioButton.Checked == true)
                                {
                                    mockItem = new Video(callNumber, title, author, copies, loanPeriod, maxRenewals);
                                    MessageBox.Show(mockItem.ToString());
                                    items.Add(mockItem);
                                }
                                if (newBookRadioButton.Checked == true)
                                {
                                    mockItem = new NewBook(callNumber, title, author, copies, loanPeriod, maxRenewals);
                                    MessageBox.Show(mockItem.ToString());
                                    items.Add(mockItem);
                                }
                                if (dvdRadioButton.Checked == true)
                                {
                                    mockItem = new DVD(callNumber, title, author, copies, loanPeriod, maxRenewals);
                                    MessageBox.Show(mockItem.ToString());
                                    items.Add(mockItem);
                                }
                            }
                            else { MessageBox.Show("Copies cannot be less than 1.", "Error", MessageBoxButtons.OK); }
                        }
                    }
                    else { MessageBox.Show("Author cannot be empty.", "Error", MessageBoxButtons.OK); }
                }
                else { MessageBox.Show("Title cannot be empty.", "Error", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("Call Number Invalid.", "Error", MessageBoxButtons.OK); }
        }

        private void UpdateDefaults()
        {
            if (bookRadioButton.Checked == true)
            {

                loan21RadioButton.Checked = true;
                fourRenewalRadioButton.Checked = true;

            }
            if (cdRadioButton.Checked == true)
            {
                
                loan21RadioButton.Checked = true;
                twoRenewalRadioButton.Checked = true;
            }
            if (videoRadioButton.Checked == true)
            {
                
                loan7RadioButton.Checked = true;
                oneRenewalRadioButton.Checked = true;
            }
            if (newBookRadioButton.Checked == true)
            {
                
                loan21RadioButton.Checked = true;
                zeroRenewalRadioButton.Checked = true;
            }
            if (dvdRadioButton.Checked == true)
            {
                
                loan7RadioButton.Checked = true;
                zeroRenewalRadioButton.Checked = true;
            }
        }

        private void cdRadioButton_Click(object sender, EventArgs e)
        {
            UpdateDefaults();
        }

        private void videoRadioButton_Click(object sender, EventArgs e)
        {
            UpdateDefaults();
        }

        private void dvdRadioButton_Click(object sender, EventArgs e)
        {
            UpdateDefaults();
        }

        private void newBookRadioButton_Click(object sender, EventArgs e)
        {
            UpdateDefaults();
        }

        private void bookRadioButton_Click(object sender, EventArgs e)
        {
            UpdateDefaults();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
            
                this.Hide();
            

            
        }
    }
}
