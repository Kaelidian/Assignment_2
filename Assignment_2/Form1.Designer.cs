namespace Assignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addLoanItemButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.renewButton = new System.Windows.Forms.Button();
            this.confirmationListBox = new System.Windows.Forms.ListBox();
            this.collectionListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchInputTextBox = new System.Windows.Forms.TextBox();
            this.sbAuthorRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sbTitleRadioButton = new System.Windows.Forms.RadioButton();
            this.searchOutputListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLoanItemButton
            // 
            this.addLoanItemButton.Location = new System.Drawing.Point(297, 38);
            this.addLoanItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.addLoanItemButton.Name = "addLoanItemButton";
            this.addLoanItemButton.Size = new System.Drawing.Size(104, 58);
            this.addLoanItemButton.TabIndex = 0;
            this.addLoanItemButton.Text = "&Add To Collection";
            this.addLoanItemButton.UseVisualStyleBackColor = true;
            this.addLoanItemButton.Click += new System.EventHandler(this.addLoanItemButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(309, 23);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(123, 86);
            this.checkOutButton.TabIndex = 1;
            this.checkOutButton.Text = "Check &Out Item";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(440, 23);
            this.checkInButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(123, 86);
            this.checkInButton.TabIndex = 2;
            this.checkInButton.Text = "Check &In Item";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // renewButton
            // 
            this.renewButton.Location = new System.Drawing.Point(565, 23);
            this.renewButton.Margin = new System.Windows.Forms.Padding(4);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(123, 86);
            this.renewButton.TabIndex = 3;
            this.renewButton.Text = "&Renew Item";
            this.renewButton.UseVisualStyleBackColor = true;
            this.renewButton.Click += new System.EventHandler(this.renewButton_Click);
            // 
            // confirmationListBox
            // 
            this.confirmationListBox.FormattingEnabled = true;
            this.confirmationListBox.HorizontalScrollbar = true;
            this.confirmationListBox.ItemHeight = 16;
            this.confirmationListBox.Location = new System.Drawing.Point(5, 189);
            this.confirmationListBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmationListBox.Name = "confirmationListBox";
            this.confirmationListBox.Size = new System.Drawing.Size(675, 324);
            this.confirmationListBox.TabIndex = 4;
            // 
            // collectionListBox
            // 
            this.collectionListBox.FormattingEnabled = true;
            this.collectionListBox.ItemHeight = 16;
            this.collectionListBox.Location = new System.Drawing.Point(16, 108);
            this.collectionListBox.Margin = new System.Windows.Forms.Padding(4);
            this.collectionListBox.Name = "collectionListBox";
            this.collectionListBox.Size = new System.Drawing.Size(385, 196);
            this.collectionListBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.copyIDTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.callNumberTextBox);
            this.groupBox1.Controls.Add(this.checkInButton);
            this.groupBox1.Controls.Add(this.checkOutButton);
            this.groupBox1.Controls.Add(this.confirmationListBox);
            this.groupBox1.Controls.Add(this.renewButton);
            this.groupBox1.Location = new System.Drawing.Point(414, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(688, 514);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copy Id";
            // 
            // copyIDTextBox
            // 
            this.copyIDTextBox.Location = new System.Drawing.Point(149, 111);
            this.copyIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.copyIDTextBox.Name = "copyIDTextBox";
            this.copyIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.copyIDTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Call Number";
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(149, 58);
            this.callNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.callNumberTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(274, 22);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 58);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchOutputListBox);
            this.groupBox2.Controls.Add(this.sbTitleRadioButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sbAuthorRadioButton);
            this.groupBox2.Controls.Add(this.searchInputTextBox);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Location = new System.Drawing.Point(16, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchInputTextBox
            // 
            this.searchInputTextBox.Location = new System.Drawing.Point(103, 58);
            this.searchInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchInputTextBox.Name = "searchInputTextBox";
            this.searchInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.searchInputTextBox.TabIndex = 8;
            // 
            // sbAuthorRadioButton
            // 
            this.sbAuthorRadioButton.AutoSize = true;
            this.sbAuthorRadioButton.Location = new System.Drawing.Point(169, 18);
            this.sbAuthorRadioButton.Name = "sbAuthorRadioButton";
            this.sbAuthorRadioButton.Size = new System.Drawing.Size(66, 20);
            this.sbAuthorRadioButton.TabIndex = 9;
            this.sbAuthorRadioButton.Text = "Author";
            this.sbAuthorRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search By:";
            // 
            // sbTitleRadioButton
            // 
            this.sbTitleRadioButton.AutoSize = true;
            this.sbTitleRadioButton.Checked = true;
            this.sbTitleRadioButton.Location = new System.Drawing.Point(103, 18);
            this.sbTitleRadioButton.Name = "sbTitleRadioButton";
            this.sbTitleRadioButton.Size = new System.Drawing.Size(54, 20);
            this.sbTitleRadioButton.TabIndex = 11;
            this.sbTitleRadioButton.TabStop = true;
            this.sbTitleRadioButton.Text = "Title";
            this.sbTitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchOutputListBox
            // 
            this.searchOutputListBox.FormattingEnabled = true;
            this.searchOutputListBox.ItemHeight = 16;
            this.searchOutputListBox.Location = new System.Drawing.Point(6, 98);
            this.searchOutputListBox.Name = "searchOutputListBox";
            this.searchOutputListBox.Size = new System.Drawing.Size(373, 100);
            this.searchOutputListBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.collectionListBox);
            this.Controls.Add(this.addLoanItemButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addLoanItemButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button renewButton;
        private System.Windows.Forms.ListBox confirmationListBox;
        private System.Windows.Forms.ListBox collectionListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox copyIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox searchOutputListBox;
        private System.Windows.Forms.RadioButton sbTitleRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sbAuthorRadioButton;
        private System.Windows.Forms.TextBox searchInputTextBox;
    }
}

