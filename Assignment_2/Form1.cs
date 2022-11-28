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
            loanList = new List<LibraryLoanItem>();
            InitializeComponent();
            

        }

        private void addLoanItemButton_Click(object sender, EventArgs e)
        {
            addItemForm = new AddItemForm(loanList);
            addItemForm.ShowDialog();
        }
    }
}
