namespace ATMMachine
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PINEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ATMcardNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAccountPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectChecking = new System.Windows.Forms.RadioButton();
            this.SelectSavings = new System.Windows.Forms.RadioButton();
            this.acctSelected = new System.Windows.Forms.Button();
            this.txntypepanel = new System.Windows.Forms.Panel();
            this.selectTransaction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectWithdrawal = new System.Windows.Forms.RadioButton();
            this.selectDeposit = new System.Windows.Forms.RadioButton();
            this.TransactionPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.depbuttonclear = new System.Windows.Forms.Button();
            this.depbuttondec = new System.Windows.Forms.Button();
            this.depbutton0 = new System.Windows.Forms.Button();
            this.depbutton1 = new System.Windows.Forms.Button();
            this.depbutton2 = new System.Windows.Forms.Button();
            this.depbutton3 = new System.Windows.Forms.Button();
            this.depbutton4 = new System.Windows.Forms.Button();
            this.depbutton5 = new System.Windows.Forms.Button();
            this.depbutton6 = new System.Windows.Forms.Button();
            this.depbutton7 = new System.Windows.Forms.Button();
            this.depbutton8 = new System.Windows.Forms.Button();
            this.depbutton9 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.submitDeposit = new System.Windows.Forms.Button();
            this.depbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WithdrawalPanel = new System.Windows.Forms.Panel();
            this.FastCash = new System.Windows.Forms.GroupBox();
            this.wdother = new System.Windows.Forms.Button();
            this.wd160 = new System.Windows.Forms.Button();
            this.wd140 = new System.Windows.Forms.Button();
            this.wd120 = new System.Windows.Forms.Button();
            this.wd100 = new System.Windows.Forms.Button();
            this.wd20 = new System.Windows.Forms.Button();
            this.wd80 = new System.Windows.Forms.Button();
            this.wd40 = new System.Windows.Forms.Button();
            this.wd60 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wdotheramountpanel = new System.Windows.Forms.GroupBox();
            this.wdbuttonclear = new System.Windows.Forms.Button();
            this.wdbuttondec = new System.Windows.Forms.Button();
            this.wdbutton0 = new System.Windows.Forms.Button();
            this.wdbutton1 = new System.Windows.Forms.Button();
            this.wdbutton2 = new System.Windows.Forms.Button();
            this.wdbutton3 = new System.Windows.Forms.Button();
            this.wdbutton4 = new System.Windows.Forms.Button();
            this.wdbutton5 = new System.Windows.Forms.Button();
            this.wdbutton6 = new System.Windows.Forms.Button();
            this.wdbutton7 = new System.Windows.Forms.Button();
            this.wdbutton8 = new System.Windows.Forms.Button();
            this.wdbutton9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitcustomwdamt = new System.Windows.Forms.Button();
            this.wdAmtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.wdPanel = new System.Windows.Forms.Panel();
            this.AccountSummary = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txnType = new System.Windows.Forms.TextBox();
            this.txnAmount = new System.Windows.Forms.TextBox();
            this.newBal = new System.Windows.Forms.TextBox();
            this.endTxn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.selectAccountPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.txntypepanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TransactionPanel.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.WithdrawalPanel.SuspendLayout();
            this.FastCash.SuspendLayout();
            this.wdotheramountpanel.SuspendLayout();
            this.wdPanel.SuspendLayout();
            this.AccountSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.LoginButton);
            this.loginPanel.Controls.Add(this.PINEntry);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.ATMcardNum);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(628, 238);
            this.loginPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(279, 146);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PINEntry
            // 
            this.PINEntry.Location = new System.Drawing.Point(254, 107);
            this.PINEntry.Name = "PINEntry";
            this.PINEntry.Size = new System.Drawing.Size(139, 20);
            this.PINEntry.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN:";
            // 
            // ATMcardNum
            // 
            this.ATMcardNum.Location = new System.Drawing.Point(254, 71);
            this.ATMcardNum.Name = "ATMcardNum";
            this.ATMcardNum.Size = new System.Drawing.Size(139, 20);
            this.ATMcardNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM Card Number: ";
            // 
            // selectAccountPanel
            // 
            this.selectAccountPanel.Controls.Add(this.groupBox1);
            this.selectAccountPanel.Controls.Add(this.acctSelected);
            this.selectAccountPanel.Location = new System.Drawing.Point(9, 12);
            this.selectAccountPanel.Name = "selectAccountPanel";
            this.selectAccountPanel.Size = new System.Drawing.Size(628, 238);
            this.selectAccountPanel.TabIndex = 4;
            this.selectAccountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectAccountPanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectChecking);
            this.groupBox1.Controls.Add(this.SelectSavings);
            this.groupBox1.Location = new System.Drawing.Point(183, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Account:";
            // 
            // selectChecking
            // 
            this.selectChecking.AutoSize = true;
            this.selectChecking.Location = new System.Drawing.Point(61, 41);
            this.selectChecking.Name = "selectChecking";
            this.selectChecking.Size = new System.Drawing.Size(70, 17);
            this.selectChecking.TabIndex = 1;
            this.selectChecking.TabStop = true;
            this.selectChecking.Text = "Checking";
            this.selectChecking.UseVisualStyleBackColor = true;
            // 
            // SelectSavings
            // 
            this.SelectSavings.AutoSize = true;
            this.SelectSavings.Location = new System.Drawing.Point(61, 59);
            this.SelectSavings.Name = "SelectSavings";
            this.SelectSavings.Size = new System.Drawing.Size(63, 17);
            this.SelectSavings.TabIndex = 2;
            this.SelectSavings.TabStop = true;
            this.SelectSavings.Text = "Savings";
            this.SelectSavings.UseVisualStyleBackColor = true;
            // 
            // acctSelected
            // 
            this.acctSelected.Location = new System.Drawing.Point(248, 179);
            this.acctSelected.Name = "acctSelected";
            this.acctSelected.Size = new System.Drawing.Size(75, 23);
            this.acctSelected.TabIndex = 3;
            this.acctSelected.Text = "Continue";
            this.acctSelected.UseVisualStyleBackColor = true;
            this.acctSelected.Click += new System.EventHandler(this.acctSelected_Click);
            // 
            // txntypepanel
            // 
            this.txntypepanel.Controls.Add(this.selectTransaction);
            this.txntypepanel.Controls.Add(this.groupBox2);
            this.txntypepanel.Location = new System.Drawing.Point(12, 12);
            this.txntypepanel.Name = "txntypepanel";
            this.txntypepanel.Size = new System.Drawing.Size(628, 238);
            this.txntypepanel.TabIndex = 5;
            // 
            // selectTransaction
            // 
            this.selectTransaction.Location = new System.Drawing.Point(245, 146);
            this.selectTransaction.Name = "selectTransaction";
            this.selectTransaction.Size = new System.Drawing.Size(75, 23);
            this.selectTransaction.TabIndex = 1;
            this.selectTransaction.Text = "Continue";
            this.selectTransaction.UseVisualStyleBackColor = true;
            this.selectTransaction.Click += new System.EventHandler(this.selectTransaction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectWithdrawal);
            this.groupBox2.Controls.Add(this.selectDeposit);
            this.groupBox2.Location = new System.Drawing.Point(183, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Transaction:";
            // 
            // SelectWithdrawal
            // 
            this.SelectWithdrawal.AutoSize = true;
            this.SelectWithdrawal.Location = new System.Drawing.Point(46, 52);
            this.SelectWithdrawal.Name = "SelectWithdrawal";
            this.SelectWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.SelectWithdrawal.TabIndex = 1;
            this.SelectWithdrawal.Text = "Withdrawal";
            this.SelectWithdrawal.UseVisualStyleBackColor = true;
            // 
            // selectDeposit
            // 
            this.selectDeposit.AutoSize = true;
            this.selectDeposit.Checked = true;
            this.selectDeposit.Location = new System.Drawing.Point(46, 28);
            this.selectDeposit.Name = "selectDeposit";
            this.selectDeposit.Size = new System.Drawing.Size(61, 17);
            this.selectDeposit.TabIndex = 0;
            this.selectDeposit.TabStop = true;
            this.selectDeposit.Text = "Deposit";
            this.selectDeposit.UseVisualStyleBackColor = true;
            // 
            // TransactionPanel
            // 
            this.TransactionPanel.Controls.Add(this.AccountSummary);
            this.TransactionPanel.Controls.Add(this.label9);
            this.TransactionPanel.Controls.Add(this.depositPanel);
            this.TransactionPanel.Controls.Add(this.WithdrawalPanel);
            this.TransactionPanel.Controls.Add(this.label7);
            this.TransactionPanel.Controls.Add(this.customerNameBox);
            this.TransactionPanel.Controls.Add(this.accountNumberBox);
            this.TransactionPanel.Location = new System.Drawing.Point(6, 12);
            this.TransactionPanel.Name = "TransactionPanel";
            this.TransactionPanel.Size = new System.Drawing.Size(628, 326);
            this.TransactionPanel.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Customer:";
            // 
            // depositPanel
            // 
            this.depositPanel.Controls.Add(this.depbuttonclear);
            this.depositPanel.Controls.Add(this.depbuttondec);
            this.depositPanel.Controls.Add(this.depbutton0);
            this.depositPanel.Controls.Add(this.depbutton1);
            this.depositPanel.Controls.Add(this.depbutton2);
            this.depositPanel.Controls.Add(this.depbutton3);
            this.depositPanel.Controls.Add(this.depbutton4);
            this.depositPanel.Controls.Add(this.depbutton5);
            this.depositPanel.Controls.Add(this.depbutton6);
            this.depositPanel.Controls.Add(this.depbutton7);
            this.depositPanel.Controls.Add(this.depbutton8);
            this.depositPanel.Controls.Add(this.depbutton9);
            this.depositPanel.Controls.Add(this.label10);
            this.depositPanel.Controls.Add(this.submitDeposit);
            this.depositPanel.Controls.Add(this.depbox);
            this.depositPanel.Controls.Add(this.label6);
            this.depositPanel.Location = new System.Drawing.Point(6, 62);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(619, 238);
            this.depositPanel.TabIndex = 7;
            // 
            // depbuttonclear
            // 
            this.depbuttonclear.Location = new System.Drawing.Point(129, 154);
            this.depbuttonclear.Name = "depbuttonclear";
            this.depbuttonclear.Size = new System.Drawing.Size(55, 23);
            this.depbuttonclear.TabIndex = 15;
            this.depbuttonclear.Text = "c";
            this.depbuttonclear.UseVisualStyleBackColor = true;
            this.depbuttonclear.Click += new System.EventHandler(this.depbuttonclear_Click);
            // 
            // depbuttondec
            // 
            this.depbuttondec.Location = new System.Drawing.Point(252, 154);
            this.depbuttondec.Name = "depbuttondec";
            this.depbuttondec.Size = new System.Drawing.Size(56, 23);
            this.depbuttondec.TabIndex = 14;
            this.depbuttondec.Text = ".";
            this.depbuttondec.UseVisualStyleBackColor = true;
            this.depbuttondec.Click += new System.EventHandler(this.depbuttondec_Click);
            // 
            // depbutton0
            // 
            this.depbutton0.Location = new System.Drawing.Point(190, 154);
            this.depbutton0.Name = "depbutton0";
            this.depbutton0.Size = new System.Drawing.Size(56, 23);
            this.depbutton0.TabIndex = 13;
            this.depbutton0.Text = "0";
            this.depbutton0.UseVisualStyleBackColor = true;
            this.depbutton0.Click += new System.EventHandler(this.depbutton0_Click);
            // 
            // depbutton1
            // 
            this.depbutton1.Location = new System.Drawing.Point(252, 125);
            this.depbutton1.Name = "depbutton1";
            this.depbutton1.Size = new System.Drawing.Size(56, 23);
            this.depbutton1.TabIndex = 12;
            this.depbutton1.Text = "1";
            this.depbutton1.UseVisualStyleBackColor = true;
            this.depbutton1.Click += new System.EventHandler(this.depbutton1_Click);
            // 
            // depbutton2
            // 
            this.depbutton2.Location = new System.Drawing.Point(190, 125);
            this.depbutton2.Name = "depbutton2";
            this.depbutton2.Size = new System.Drawing.Size(56, 23);
            this.depbutton2.TabIndex = 11;
            this.depbutton2.Text = "2";
            this.depbutton2.UseVisualStyleBackColor = true;
            this.depbutton2.Click += new System.EventHandler(this.depbutton2_Click);
            // 
            // depbutton3
            // 
            this.depbutton3.Location = new System.Drawing.Point(129, 125);
            this.depbutton3.Name = "depbutton3";
            this.depbutton3.Size = new System.Drawing.Size(55, 23);
            this.depbutton3.TabIndex = 10;
            this.depbutton3.Text = "3";
            this.depbutton3.UseVisualStyleBackColor = true;
            this.depbutton3.Click += new System.EventHandler(this.depbutton3_Click);
            // 
            // depbutton4
            // 
            this.depbutton4.Location = new System.Drawing.Point(252, 96);
            this.depbutton4.Name = "depbutton4";
            this.depbutton4.Size = new System.Drawing.Size(56, 23);
            this.depbutton4.TabIndex = 9;
            this.depbutton4.Text = "4";
            this.depbutton4.UseVisualStyleBackColor = true;
            this.depbutton4.Click += new System.EventHandler(this.depbutton4_Click);
            // 
            // depbutton5
            // 
            this.depbutton5.Location = new System.Drawing.Point(190, 96);
            this.depbutton5.Name = "depbutton5";
            this.depbutton5.Size = new System.Drawing.Size(56, 23);
            this.depbutton5.TabIndex = 8;
            this.depbutton5.Text = "5";
            this.depbutton5.UseVisualStyleBackColor = true;
            this.depbutton5.Click += new System.EventHandler(this.depbutton5_Click);
            // 
            // depbutton6
            // 
            this.depbutton6.Location = new System.Drawing.Point(129, 96);
            this.depbutton6.Name = "depbutton6";
            this.depbutton6.Size = new System.Drawing.Size(55, 23);
            this.depbutton6.TabIndex = 7;
            this.depbutton6.Text = "6";
            this.depbutton6.UseVisualStyleBackColor = true;
            this.depbutton6.Click += new System.EventHandler(this.depbutton6_Click);
            // 
            // depbutton7
            // 
            this.depbutton7.Location = new System.Drawing.Point(252, 67);
            this.depbutton7.Name = "depbutton7";
            this.depbutton7.Size = new System.Drawing.Size(56, 23);
            this.depbutton7.TabIndex = 6;
            this.depbutton7.Text = "7";
            this.depbutton7.UseVisualStyleBackColor = true;
            this.depbutton7.Click += new System.EventHandler(this.depbutton7_Click);
            // 
            // depbutton8
            // 
            this.depbutton8.Location = new System.Drawing.Point(190, 67);
            this.depbutton8.Name = "depbutton8";
            this.depbutton8.Size = new System.Drawing.Size(56, 23);
            this.depbutton8.TabIndex = 5;
            this.depbutton8.Text = "8";
            this.depbutton8.UseVisualStyleBackColor = true;
            this.depbutton8.Click += new System.EventHandler(this.depbutton8_Click);
            // 
            // depbutton9
            // 
            this.depbutton9.Location = new System.Drawing.Point(129, 67);
            this.depbutton9.Name = "depbutton9";
            this.depbutton9.Size = new System.Drawing.Size(55, 23);
            this.depbutton9.TabIndex = 4;
            this.depbutton9.Text = "9";
            this.depbutton9.UseVisualStyleBackColor = true;
            this.depbutton9.Click += new System.EventHandler(this.depbutton9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Make a Deposit";
            // 
            // submitDeposit
            // 
            this.submitDeposit.Location = new System.Drawing.Point(348, 96);
            this.submitDeposit.Name = "submitDeposit";
            this.submitDeposit.Size = new System.Drawing.Size(75, 23);
            this.submitDeposit.TabIndex = 2;
            this.submitDeposit.Text = "Submit";
            this.submitDeposit.UseVisualStyleBackColor = true;
            this.submitDeposit.Click += new System.EventHandler(this.submitDeposit_Click);
            // 
            // depbox
            // 
            this.depbox.Location = new System.Drawing.Point(244, 35);
            this.depbox.Name = "depbox";
            this.depbox.ReadOnly = true;
            this.depbox.Size = new System.Drawing.Size(179, 20);
            this.depbox.TabIndex = 1;
            this.depbox.TextChanged += new System.EventHandler(this.depbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount To Deposit:";
            // 
            // WithdrawalPanel
            // 
            this.WithdrawalPanel.Controls.Add(this.wdPanel);
            this.WithdrawalPanel.Controls.Add(this.wdotheramountpanel);
            this.WithdrawalPanel.Controls.Add(this.label5);
            this.WithdrawalPanel.Location = new System.Drawing.Point(6, 62);
            this.WithdrawalPanel.Name = "WithdrawalPanel";
            this.WithdrawalPanel.Size = new System.Drawing.Size(619, 238);
            this.WithdrawalPanel.TabIndex = 5;
            // 
            // FastCash
            // 
            this.FastCash.Controls.Add(this.wdother);
            this.FastCash.Controls.Add(this.wd160);
            this.FastCash.Controls.Add(this.wd140);
            this.FastCash.Controls.Add(this.wd120);
            this.FastCash.Controls.Add(this.wd100);
            this.FastCash.Controls.Add(this.wd20);
            this.FastCash.Controls.Add(this.wd80);
            this.FastCash.Controls.Add(this.wd40);
            this.FastCash.Controls.Add(this.wd60);
            this.FastCash.Location = new System.Drawing.Point(7, 11);
            this.FastCash.Name = "FastCash";
            this.FastCash.Size = new System.Drawing.Size(271, 184);
            this.FastCash.TabIndex = 4;
            this.FastCash.TabStop = false;
            this.FastCash.Text = "Fast Cash";
            // 
            // wdother
            // 
            this.wdother.Location = new System.Drawing.Point(82, 142);
            this.wdother.Name = "wdother";
            this.wdother.Size = new System.Drawing.Size(99, 23);
            this.wdother.TabIndex = 8;
            this.wdother.Text = "Other Amount";
            this.wdother.UseVisualStyleBackColor = true;
            this.wdother.Click += new System.EventHandler(this.wdother_Click);
            // 
            // wd160
            // 
            this.wd160.Location = new System.Drawing.Point(175, 107);
            this.wd160.Name = "wd160";
            this.wd160.Size = new System.Drawing.Size(75, 23);
            this.wd160.TabIndex = 7;
            this.wd160.Text = "$160";
            this.wd160.UseVisualStyleBackColor = true;
            this.wd160.Click += new System.EventHandler(this.wd180_Click);
            // 
            // wd140
            // 
            this.wd140.Location = new System.Drawing.Point(175, 78);
            this.wd140.Name = "wd140";
            this.wd140.Size = new System.Drawing.Size(75, 23);
            this.wd140.TabIndex = 6;
            this.wd140.Text = "$140";
            this.wd140.UseVisualStyleBackColor = true;
            this.wd140.Click += new System.EventHandler(this.wd160_Click);
            // 
            // wd120
            // 
            this.wd120.Location = new System.Drawing.Point(175, 49);
            this.wd120.Name = "wd120";
            this.wd120.Size = new System.Drawing.Size(75, 23);
            this.wd120.TabIndex = 5;
            this.wd120.Text = "$120";
            this.wd120.UseVisualStyleBackColor = true;
            this.wd120.Click += new System.EventHandler(this.wd120_Click);
            // 
            // wd100
            // 
            this.wd100.Location = new System.Drawing.Point(175, 19);
            this.wd100.Name = "wd100";
            this.wd100.Size = new System.Drawing.Size(75, 23);
            this.wd100.TabIndex = 4;
            this.wd100.Text = "$100";
            this.wd100.UseVisualStyleBackColor = true;
            this.wd100.Click += new System.EventHandler(this.wd100_Click);
            // 
            // wd20
            // 
            this.wd20.Location = new System.Drawing.Point(19, 19);
            this.wd20.Name = "wd20";
            this.wd20.Size = new System.Drawing.Size(75, 23);
            this.wd20.TabIndex = 0;
            this.wd20.Text = "$20";
            this.wd20.UseVisualStyleBackColor = true;
            this.wd20.Click += new System.EventHandler(this.wd20_Click);
            // 
            // wd80
            // 
            this.wd80.Location = new System.Drawing.Point(19, 107);
            this.wd80.Name = "wd80";
            this.wd80.Size = new System.Drawing.Size(75, 23);
            this.wd80.TabIndex = 3;
            this.wd80.Text = "$80";
            this.wd80.UseVisualStyleBackColor = true;
            this.wd80.Click += new System.EventHandler(this.wd80_Click);
            // 
            // wd40
            // 
            this.wd40.Location = new System.Drawing.Point(19, 49);
            this.wd40.Name = "wd40";
            this.wd40.Size = new System.Drawing.Size(75, 23);
            this.wd40.TabIndex = 1;
            this.wd40.Text = "$40";
            this.wd40.UseVisualStyleBackColor = true;
            this.wd40.Click += new System.EventHandler(this.wd40_Click);
            // 
            // wd60
            // 
            this.wd60.Location = new System.Drawing.Point(19, 78);
            this.wd60.Name = "wd60";
            this.wd60.Size = new System.Drawing.Size(75, 23);
            this.wd60.TabIndex = 2;
            this.wd60.Text = "$60";
            this.wd60.UseVisualStyleBackColor = true;
            this.wd60.Click += new System.EventHandler(this.wd60_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Make a Withdrawal";
            // 
            // wdotheramountpanel
            // 
            this.wdotheramountpanel.Controls.Add(this.wdbuttonclear);
            this.wdotheramountpanel.Controls.Add(this.wdbuttondec);
            this.wdotheramountpanel.Controls.Add(this.wdbutton0);
            this.wdotheramountpanel.Controls.Add(this.wdbutton1);
            this.wdotheramountpanel.Controls.Add(this.wdbutton2);
            this.wdotheramountpanel.Controls.Add(this.wdbutton3);
            this.wdotheramountpanel.Controls.Add(this.wdbutton4);
            this.wdotheramountpanel.Controls.Add(this.wdbutton5);
            this.wdotheramountpanel.Controls.Add(this.wdbutton6);
            this.wdotheramountpanel.Controls.Add(this.wdbutton7);
            this.wdotheramountpanel.Controls.Add(this.wdbutton8);
            this.wdotheramountpanel.Controls.Add(this.wdbutton9);
            this.wdotheramountpanel.Controls.Add(this.label4);
            this.wdotheramountpanel.Controls.Add(this.label3);
            this.wdotheramountpanel.Controls.Add(this.submitcustomwdamt);
            this.wdotheramountpanel.Controls.Add(this.wdAmtBox);
            this.wdotheramountpanel.Location = new System.Drawing.Point(168, 24);
            this.wdotheramountpanel.Name = "wdotheramountpanel";
            this.wdotheramountpanel.Size = new System.Drawing.Size(271, 203);
            this.wdotheramountpanel.TabIndex = 5;
            this.wdotheramountpanel.TabStop = false;
            this.wdotheramountpanel.Text = "Other Amount";
            // 
            // wdbuttonclear
            // 
            this.wdbuttonclear.Location = new System.Drawing.Point(22, 153);
            this.wdbuttonclear.Name = "wdbuttonclear";
            this.wdbuttonclear.Size = new System.Drawing.Size(38, 23);
            this.wdbuttonclear.TabIndex = 15;
            this.wdbuttonclear.Text = "c";
            this.wdbuttonclear.UseVisualStyleBackColor = true;
            this.wdbuttonclear.Click += new System.EventHandler(this.wdbuttonclear_Click);
            // 
            // wdbuttondec
            // 
            this.wdbuttondec.Location = new System.Drawing.Point(113, 153);
            this.wdbuttondec.Name = "wdbuttondec";
            this.wdbuttondec.Size = new System.Drawing.Size(40, 23);
            this.wdbuttondec.TabIndex = 14;
            this.wdbuttondec.Text = ".";
            this.wdbuttondec.UseVisualStyleBackColor = true;
            this.wdbuttondec.Click += new System.EventHandler(this.wdbuttondec_Click);
            // 
            // wdbutton0
            // 
            this.wdbutton0.Location = new System.Drawing.Point(66, 153);
            this.wdbutton0.Name = "wdbutton0";
            this.wdbutton0.Size = new System.Drawing.Size(41, 23);
            this.wdbutton0.TabIndex = 13;
            this.wdbutton0.Text = "0";
            this.wdbutton0.UseVisualStyleBackColor = true;
            this.wdbutton0.Click += new System.EventHandler(this.wdbutton0_Click);
            // 
            // wdbutton1
            // 
            this.wdbutton1.Location = new System.Drawing.Point(113, 124);
            this.wdbutton1.Name = "wdbutton1";
            this.wdbutton1.Size = new System.Drawing.Size(40, 23);
            this.wdbutton1.TabIndex = 12;
            this.wdbutton1.Text = "1";
            this.wdbutton1.UseVisualStyleBackColor = true;
            this.wdbutton1.Click += new System.EventHandler(this.wdbutton1_Click);
            // 
            // wdbutton2
            // 
            this.wdbutton2.Location = new System.Drawing.Point(66, 124);
            this.wdbutton2.Name = "wdbutton2";
            this.wdbutton2.Size = new System.Drawing.Size(41, 23);
            this.wdbutton2.TabIndex = 11;
            this.wdbutton2.Text = "2";
            this.wdbutton2.UseVisualStyleBackColor = true;
            this.wdbutton2.Click += new System.EventHandler(this.wdbutton2_Click);
            // 
            // wdbutton3
            // 
            this.wdbutton3.Location = new System.Drawing.Point(22, 124);
            this.wdbutton3.Name = "wdbutton3";
            this.wdbutton3.Size = new System.Drawing.Size(37, 23);
            this.wdbutton3.TabIndex = 10;
            this.wdbutton3.Text = "3";
            this.wdbutton3.UseVisualStyleBackColor = true;
            this.wdbutton3.Click += new System.EventHandler(this.wdbutton3_Click);
            // 
            // wdbutton4
            // 
            this.wdbutton4.Location = new System.Drawing.Point(113, 95);
            this.wdbutton4.Name = "wdbutton4";
            this.wdbutton4.Size = new System.Drawing.Size(40, 23);
            this.wdbutton4.TabIndex = 9;
            this.wdbutton4.Text = "4";
            this.wdbutton4.UseVisualStyleBackColor = true;
            this.wdbutton4.Click += new System.EventHandler(this.wdbutton4_Click);
            // 
            // wdbutton5
            // 
            this.wdbutton5.Location = new System.Drawing.Point(66, 95);
            this.wdbutton5.Name = "wdbutton5";
            this.wdbutton5.Size = new System.Drawing.Size(41, 23);
            this.wdbutton5.TabIndex = 8;
            this.wdbutton5.Text = "5";
            this.wdbutton5.UseVisualStyleBackColor = true;
            this.wdbutton5.Click += new System.EventHandler(this.wdbutton5_Click);
            // 
            // wdbutton6
            // 
            this.wdbutton6.Location = new System.Drawing.Point(22, 95);
            this.wdbutton6.Name = "wdbutton6";
            this.wdbutton6.Size = new System.Drawing.Size(37, 23);
            this.wdbutton6.TabIndex = 7;
            this.wdbutton6.Text = "6";
            this.wdbutton6.UseVisualStyleBackColor = true;
            this.wdbutton6.Click += new System.EventHandler(this.wdbutton6_Click);
            // 
            // wdbutton7
            // 
            this.wdbutton7.Location = new System.Drawing.Point(113, 66);
            this.wdbutton7.Name = "wdbutton7";
            this.wdbutton7.Size = new System.Drawing.Size(40, 23);
            this.wdbutton7.TabIndex = 6;
            this.wdbutton7.Text = "7";
            this.wdbutton7.UseVisualStyleBackColor = true;
            this.wdbutton7.Click += new System.EventHandler(this.wdbutton7_Click);
            // 
            // wdbutton8
            // 
            this.wdbutton8.Location = new System.Drawing.Point(66, 66);
            this.wdbutton8.Name = "wdbutton8";
            this.wdbutton8.Size = new System.Drawing.Size(41, 23);
            this.wdbutton8.TabIndex = 5;
            this.wdbutton8.Text = "8";
            this.wdbutton8.UseVisualStyleBackColor = true;
            this.wdbutton8.Click += new System.EventHandler(this.wdbutton8_Click);
            // 
            // wdbutton9
            // 
            this.wdbutton9.Location = new System.Drawing.Point(22, 66);
            this.wdbutton9.Name = "wdbutton9";
            this.wdbutton9.Size = new System.Drawing.Size(38, 23);
            this.wdbutton9.TabIndex = 4;
            this.wdbutton9.Text = "9";
            this.wdbutton9.UseVisualStyleBackColor = true;
            this.wdbutton9.Click += new System.EventHandler(this.wdbutton9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please enter an amount that\'s a multiple of 20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount to Withdraw:";
            // 
            // submitcustomwdamt
            // 
            this.submitcustomwdamt.Location = new System.Drawing.Point(169, 174);
            this.submitcustomwdamt.Name = "submitcustomwdamt";
            this.submitcustomwdamt.Size = new System.Drawing.Size(75, 23);
            this.submitcustomwdamt.TabIndex = 1;
            this.submitcustomwdamt.Text = "Submit";
            this.submitcustomwdamt.UseVisualStyleBackColor = true;
            this.submitcustomwdamt.Click += new System.EventHandler(this.submitcustomwdamt_Click);
            // 
            // wdAmtBox
            // 
            this.wdAmtBox.Location = new System.Drawing.Point(141, 33);
            this.wdAmtBox.Name = "wdAmtBox";
            this.wdAmtBox.ReadOnly = true;
            this.wdAmtBox.Size = new System.Drawing.Size(100, 20);
            this.wdAmtBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Account:";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(451, 12);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.ReadOnly = true;
            this.customerNameBox.Size = new System.Drawing.Size(157, 20);
            this.customerNameBox.TabIndex = 6;
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Location = new System.Drawing.Point(65, 12);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.ReadOnly = true;
            this.accountNumberBox.Size = new System.Drawing.Size(116, 20);
            this.accountNumberBox.TabIndex = 5;
            // 
            // wdPanel
            // 
            this.wdPanel.Controls.Add(this.FastCash);
            this.wdPanel.Location = new System.Drawing.Point(155, 24);
            this.wdPanel.Name = "wdPanel";
            this.wdPanel.Size = new System.Drawing.Size(284, 211);
            this.wdPanel.TabIndex = 7;
            // 
            // AccountSummary
            // 
            this.AccountSummary.Controls.Add(this.label13);
            this.AccountSummary.Controls.Add(this.label12);
            this.AccountSummary.Controls.Add(this.label11);
            this.AccountSummary.Controls.Add(this.endTxn);
            this.AccountSummary.Controls.Add(this.newBal);
            this.AccountSummary.Controls.Add(this.txnAmount);
            this.AccountSummary.Controls.Add(this.txnType);
            this.AccountSummary.Controls.Add(this.label8);
            this.AccountSummary.Location = new System.Drawing.Point(6, 51);
            this.AccountSummary.Name = "AccountSummary";
            this.AccountSummary.Size = new System.Drawing.Size(616, 249);
            this.AccountSummary.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Transaction Summary";
            // 
            // txnType
            // 
            this.txnType.Location = new System.Drawing.Point(135, 43);
            this.txnType.Name = "txnType";
            this.txnType.ReadOnly = true;
            this.txnType.Size = new System.Drawing.Size(248, 20);
            this.txnType.TabIndex = 1;
            // 
            // txnAmount
            // 
            this.txnAmount.Location = new System.Drawing.Point(135, 74);
            this.txnAmount.Name = "txnAmount";
            this.txnAmount.ReadOnly = true;
            this.txnAmount.Size = new System.Drawing.Size(248, 20);
            this.txnAmount.TabIndex = 2;
            // 
            // newBal
            // 
            this.newBal.Location = new System.Drawing.Point(135, 101);
            this.newBal.Name = "newBal";
            this.newBal.ReadOnly = true;
            this.newBal.Size = new System.Drawing.Size(248, 20);
            this.newBal.TabIndex = 3;
            // 
            // endTxn
            // 
            this.endTxn.Location = new System.Drawing.Point(218, 142);
            this.endTxn.Name = "endTxn";
            this.endTxn.Size = new System.Drawing.Size(90, 23);
            this.endTxn.TabIndex = 4;
            this.endTxn.Text = "Logout";
            this.endTxn.UseVisualStyleBackColor = true;
            this.endTxn.Click += new System.EventHandler(this.endTxn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Transaction Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Amount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "New Balance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 349);
            this.Controls.Add(this.TransactionPanel);
            this.Controls.Add(this.selectAccountPanel);
            this.Controls.Add(this.txntypepanel);
            this.Controls.Add(this.loginPanel);
            this.Name = "Form1";
            this.Text = "ATM Machine";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.selectAccountPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txntypepanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TransactionPanel.ResumeLayout(false);
            this.TransactionPanel.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.WithdrawalPanel.ResumeLayout(false);
            this.WithdrawalPanel.PerformLayout();
            this.FastCash.ResumeLayout(false);
            this.wdotheramountpanel.ResumeLayout(false);
            this.wdotheramountpanel.PerformLayout();
            this.wdPanel.ResumeLayout(false);
            this.AccountSummary.ResumeLayout(false);
            this.AccountSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox PINEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ATMcardNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel selectAccountPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton selectChecking;
        private System.Windows.Forms.RadioButton SelectSavings;
        private System.Windows.Forms.Button acctSelected;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel txntypepanel;
        private System.Windows.Forms.Button selectTransaction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SelectWithdrawal;
        private System.Windows.Forms.RadioButton selectDeposit;
        private System.Windows.Forms.Panel TransactionPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Panel WithdrawalPanel;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submitDeposit;
        private System.Windows.Forms.TextBox depbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox wdotheramountpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitcustomwdamt;
        private System.Windows.Forms.TextBox wdAmtBox;
        private System.Windows.Forms.GroupBox FastCash;
        private System.Windows.Forms.Button wdother;
        private System.Windows.Forms.Button wd160;
        private System.Windows.Forms.Button wd140;
        private System.Windows.Forms.Button wd120;
        private System.Windows.Forms.Button wd100;
        private System.Windows.Forms.Button wd20;
        private System.Windows.Forms.Button wd80;
        private System.Windows.Forms.Button wd40;
        private System.Windows.Forms.Button wd60;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Button wdbuttonclear;
        private System.Windows.Forms.Button wdbuttondec;
        private System.Windows.Forms.Button wdbutton0;
        private System.Windows.Forms.Button wdbutton1;
        private System.Windows.Forms.Button wdbutton2;
        private System.Windows.Forms.Button wdbutton3;
        private System.Windows.Forms.Button wdbutton4;
        private System.Windows.Forms.Button wdbutton5;
        private System.Windows.Forms.Button wdbutton6;
        private System.Windows.Forms.Button wdbutton7;
        private System.Windows.Forms.Button wdbutton8;
        private System.Windows.Forms.Button wdbutton9;
        private System.Windows.Forms.Button depbutton4;
        private System.Windows.Forms.Button depbutton5;
        private System.Windows.Forms.Button depbutton6;
        private System.Windows.Forms.Button depbutton7;
        private System.Windows.Forms.Button depbutton8;
        private System.Windows.Forms.Button depbutton9;
        private System.Windows.Forms.Button depbuttonclear;
        private System.Windows.Forms.Button depbuttondec;
        private System.Windows.Forms.Button depbutton0;
        private System.Windows.Forms.Button depbutton1;
        private System.Windows.Forms.Button depbutton2;
        private System.Windows.Forms.Button depbutton3;
        private System.Windows.Forms.Panel wdPanel;
        private System.Windows.Forms.Panel AccountSummary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button endTxn;
        private System.Windows.Forms.TextBox newBal;
        private System.Windows.Forms.TextBox txnAmount;
        private System.Windows.Forms.TextBox txnType;
        private System.Windows.Forms.Label label8;
    }
}

