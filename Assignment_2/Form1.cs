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

                Utility.CallNumber cnumber = new Utility.CallNumber(callNum);


                for (int i = 0; i < loanList.Count; i++)
                {
                    if (loanList[i].CallNumber == callNum)
                    {
                        loanList[i].CheckOut(callNum);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect length.");
            }
            

        }


    }
}
