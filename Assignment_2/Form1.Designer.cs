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
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLoanItemButton
            // 
            this.addLoanItemButton.Location = new System.Drawing.Point(12, 12);
            this.addLoanItemButton.Name = "addLoanItemButton";
            this.addLoanItemButton.Size = new System.Drawing.Size(92, 70);
            this.addLoanItemButton.TabIndex = 0;
            this.addLoanItemButton.Text = "&Add To Collection";
            this.addLoanItemButton.UseVisualStyleBackColor = true;
            this.addLoanItemButton.Click += new System.EventHandler(this.addLoanItemButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(457, 14);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(92, 70);
            this.checkOutButton.TabIndex = 1;
            this.checkOutButton.Text = "Check &Out Item";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(458, 90);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(92, 70);
            this.checkInButton.TabIndex = 2;
            this.checkInButton.Text = "Check &In Item";
            this.checkInButton.UseVisualStyleBackColor = true;
            // 
            // renewButton
            // 
            this.renewButton.Location = new System.Drawing.Point(457, 168);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(92, 70);
            this.renewButton.TabIndex = 3;
            this.renewButton.Text = "&Renew Item";
            this.renewButton.UseVisualStyleBackColor = true;
            // 
            // confirmationListBox
            // 
            this.confirmationListBox.FormattingEnabled = true;
            this.confirmationListBox.Location = new System.Drawing.Point(6, 244);
            this.confirmationListBox.Name = "confirmationListBox";
            this.confirmationListBox.Size = new System.Drawing.Size(560, 160);
            this.confirmationListBox.TabIndex = 4;
            // 
            // collectionListBox
            // 
            this.collectionListBox.FormattingEnabled = true;
            this.collectionListBox.Location = new System.Drawing.Point(12, 88);
            this.collectionListBox.Name = "collectionListBox";
            this.collectionListBox.Size = new System.Drawing.Size(198, 342);
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
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 418);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Manager";
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(96, 44);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.callNumberTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Call Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copy Id";
            // 
            // copyIDTextBox
            // 
            this.copyIDTextBox.Location = new System.Drawing.Point(96, 87);
            this.copyIDTextBox.Name = "copyIDTextBox";
            this.copyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyIDTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.collectionListBox);
            this.Controls.Add(this.addLoanItemButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

