using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMMachine
{
    public partial class Form1 : Form
    {
        //initializes variables used during the transaction
        Transaction txn;
        StringBuilder depString;
        StringBuilder wdString;
        DatabaseUtility db = new DatabaseUtility();
        public Form1()
        {
            InitializeComponent();
            //sets the login panel visible
            loginPanel.Visible = true;
            txntypepanel.Visible = false;
            selectAccountPanel.Visible = false;
            TransactionPanel.Visible = false;
            AccountSummary.Visible = false;
            
        }

        private void selectAccountPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Validates the login information to move onto the next screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string atmCard = ATMcardNum.Text.Trim();
            string pinNum = PINEntry.Text.Trim();

            
            bool loginValid = db.loginValidation(atmCard, pinNum);
            if (loginValid)
            {
                txn = new Transaction();
                if (atmCard.Length > 3 && pinNum.Length>3)
                {
                    txn.CustNumber = db.getCustomerNumber(atmCard, pinNum);
                    txntypepanel.Visible = true;
                    loginPanel.Visible = false;
                    ATMcardNum.Clear();
                    PINEntry.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter an account number and PIN");
                }
                
                
            }
            else
            {
                MessageBox.Show("Login error- please enter valid account number and pin");
            }
        }

        /// <summary>
        /// Selects the kind of transaction the user wants to do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectTransaction_Click(object sender, EventArgs e)
        {
            if (selectDeposit.Checked)
            {
                txn.TransactionType = 'D';
                selectAccountPanel.Visible = true;
                txntypepanel.Visible = false;

            }
            else if (SelectWithdrawal.Checked)
            {
                txn.TransactionType = 'W';
                selectAccountPanel.Visible = true;
                txntypepanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a transaction type");
            }

        }

        /// <summary>
        /// allows user to select account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acctSelected_Click(object sender, EventArgs e)
        {
            if (SelectSavings.Checked==true)
            {
                txn.AccountType = 's';
            }
            else
            {
                txn.AccountType = 'c';
            }
            int intermediateAcct;
            //fetches datatable with account information from database
            DataTable dt = db.accountInformation(txn.CustNumber, txn.AccountType);
            
            try
            {
                //parses datatable for relevant information for account selected
                string custName = dt.Rows[0]["customer_name"].ToString();
                string acct = dt.Rows[0]["account_number"].ToString();
                int.TryParse(acct, out intermediateAcct);
                txn.AcctNumber = intermediateAcct;
                txn.CustName = custName;
            }
            catch (IndexOutOfRangeException ire)
            {
                intermediateAcct = 0;
            }
            
            
            if (intermediateAcct == 0)
            {
                MessageBox.Show("Invalid Account Type. Please Select a different value.");
            }
            else
            {
                //loads acct balance into transaction for processing
                txn.PrevBalance = db.getBalance(txn.AcctNumber);
                //sets the transaction panel for visible
                TransactionPanel.Visible = true;
                AccountSummary.Visible = false;
                selectAccountPanel.Visible = false;
                //determines which transaction module will be visible based on transaction requested
                if (txn.TransactionType == 'D')
                {
                    depositPanel.Visible = true;
                    WithdrawalPanel.Visible = false;
                    accountNumberBox.Text = txn.AcctNumber.ToString();
                    customerNameBox.Text = txn.CustName;
                    //builds string from button clicks
                    depString = new StringBuilder();
                }
                else
                {
                    WithdrawalPanel.Visible = true;
                    FastCash.Visible = true;
                    depositPanel.Visible = false;
                    wdotheramountpanel.Visible = false;
                    accountNumberBox.Text = txn.AcctNumber.ToString();
                    customerNameBox.Text = txn.CustName;
                    //builds string from button clicks 
                    wdString = new StringBuilder();
                }
            }
        }
        /// <summary>
        /// Adds 9 to string for value when button 9 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton9_Click(object sender, EventArgs e)
        {
            depString.Append("9");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }
        /// <summary>
        /// Adds 8 to string for value when button 8 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton8_Click(object sender, EventArgs e)
        {
            depString.Append("8");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }
        /// <summary>
        /// Adds 7 to string for value when button 7 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton7_Click(object sender, EventArgs e)
        {
            depString.Append("7");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// Adds 6 to string for value when button 6 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton6_Click(object sender, EventArgs e)
        {
            depString.Append("6");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// Adds 5 to string for value when button 5 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton5_Click(object sender, EventArgs e)
        {
            depString.Append("5");
            depbox.Clear();
            depbox.Text = depString.ToString();

        }
        /// <summary>
        /// Adds 4 to string for value when button 4 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton4_Click(object sender, EventArgs e)
        {
            depString.Append("4");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }
        /// <summary>
        /// Adds 3 to string for value when button 3 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton3_Click(object sender, EventArgs e)
        {
            depString.Append("3");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// Adds 2 to string for value when button 2 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton2_Click(object sender, EventArgs e)
        {
            depString.Append("2");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// Adds 1 to string for value when button 1 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton1_Click(object sender, EventArgs e)
        {
            depString.Append("1");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// Adds 0 to string for value when button 0 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbutton0_Click(object sender, EventArgs e)
        {
            depString.Append("0");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// Adds decimal to string for value when button decimal is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbuttondec_Click(object sender, EventArgs e)
        {
            depString.Append(".");
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        /// <summary>
        /// clears string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depbuttonclear_Click(object sender, EventArgs e)
        {
            depString.Clear();
            depbox.Clear();
            depbox.Text = depString.ToString();
        }

        private void depbox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// submits deposit to database for processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitDeposit_Click(object sender, EventArgs e)
        {
            //initialize
            decimal deposit;
            //validates syntax through regex
            bool validSyntax = ATMFunction.validateEntry(depString.ToString());
            if (validSyntax)
            {

                Decimal.TryParse(depString.ToString(), out deposit);

                txn.Amount = deposit;
                db.makeDeposit(txn);
                AccountSummary.Visible = true;
                WithdrawalPanel.Visible = false;
                    
                txnType.Text = "Deposit";
                txnAmount.Text = txn.Amount.ToString("c");
                decimal newBalance = ATMFunction.updatedBalance(txn);
                newBal.Text = newBalance.ToString("c");
                depbox.Clear();
                depString.Clear();

            }
            else
            {
                deposit = 0;
                MessageBox.Show("Invalid Entry, please enter the amount in the following format 1234.56");
                depbox.Clear();
                depString.Clear();
            }

        }
        /// <summary>
        /// withdraws 20 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd20_Click(object sender, EventArgs e)
        {
            txn.Amount = 20;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }
        /// <summary>
        /// withdraws 40 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd40_Click(object sender, EventArgs e)
        {
            txn.Amount = 40;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }
        /// <summary>
        /// withdraws 60 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd60_Click(object sender, EventArgs e)
        {
            txn.Amount = 60;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }
        /// <summary>
        /// withdraws 80 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd80_Click(object sender, EventArgs e)
        {
            txn.Amount = 80;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }

        /// <summary>
        /// withdraws 100 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd100_Click(object sender, EventArgs e)
        {
            txn.Amount = 100;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }

        /// <summary>
        /// withdraws 120 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd120_Click(object sender, EventArgs e)
        {
            txn.Amount = 120;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");

        }
        /// <summary>
        /// withdraws 140 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wd160_Click(object sender, EventArgs e)
        {
            txn.Amount = 140;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }

        /// <summary>
        /// withdraws 160 from account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void wd180_Click(object sender, EventArgs e)
        {
            txn.Amount = 160;
            ATMFunction.validateWithdrawal(txn.Amount, txn.PrevBalance);
            db.makeWithdrawal(txn);
            WithdrawalPanel.Visible = false;
            AccountSummary.Visible = true;
            txnType.Text = "Withdrawal";
            txnAmount.Text = txn.Amount.ToString("c");
            decimal newBalance = ATMFunction.updatedBalance(txn);
            newBal.Text = newBalance.ToString("c");
        }

        //allows user to enter custom amount
        private void wdother_Click(object sender, EventArgs e)
        {
            wdPanel.Visible = false;
            wdotheramountpanel.Visible = true;
            
        }
        //the group of buttons add their corresponding value to the string for submission of custom withdrawal amount
        private void wdbutton9_Click(object sender, EventArgs e)
        {
            wdString.Append("9");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();

        }

        private void wdbutton8_Click(object sender, EventArgs e)
        {
            wdString.Append("8");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton7_Click(object sender, EventArgs e)
        {
            wdString.Append("7");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton6_Click(object sender, EventArgs e)
        {

            wdString.Append("6");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton5_Click(object sender, EventArgs e)
        {
            wdString.Append("5");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton4_Click(object sender, EventArgs e)
        {

            wdString.Append("4");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton3_Click(object sender, EventArgs e)
        {
            wdString.Append("3");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton2_Click(object sender, EventArgs e)
        {
            wdString.Append("2");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbutton1_Click(object sender, EventArgs e)
        {
            wdString.Append("1");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbuttonclear_Click(object sender, EventArgs e)
        {
            wdString.Clear();
            wdAmtBox.Clear();
        }

        private void wdbutton0_Click(object sender, EventArgs e)
        {
            wdString.Append("0");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }

        private void wdbuttondec_Click(object sender, EventArgs e)
        {

            wdString.Append(".");
            wdAmtBox.Clear();
            wdAmtBox.Text = wdString.ToString();
        }
        /// <summary>
        /// This submits the custom withdrawal amount to the database for processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitcustomwdamt_Click(object sender, EventArgs e)
        {
            decimal withdrawal = 0;
            //validates withdrawal format
            bool validSyntax = ATMFunction.validateEntry(wdString.ToString());
            if (validSyntax)
            {

                Decimal.TryParse(wdString.ToString(), out withdrawal);
                bool validateTwenty = ATMFunction.validateWithdrawalAmount(withdrawal);
                //validates withdrawal amount
                if (validateTwenty)
                {
                    txn.Amount = withdrawal;

                    db.makeWithdrawal(txn);

                    AccountSummary.Visible = true;
                    WithdrawalPanel.Visible = false;
                    
                    txnType.Text = "Withdrawal";
                    txnAmount.Text = txn.Amount.ToString("c");
                    decimal newBalance = ATMFunction.updatedBalance(txn);
                    newBal.Text = newBalance.ToString("c");
                    wdAmtBox.Clear();
                    wdString.Clear();


                }
                else
                {
                    MessageBox.Show("Please select a multiple of $20");
                    wdAmtBox.Clear();
                    wdString.Clear();
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry, please enter the amount in the following format 1234.56");
                wdAmtBox.Clear();
                wdString.Clear();
            }

        }

        /// <summary>
        /// resets program back for more transactions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTxn_Click(object sender, EventArgs e)
        {
            accountNumberBox.Clear();
            customerNameBox.Clear();
            txnType.Clear();
            txnAmount.Clear();
            newBal.Clear();
            TransactionPanel.Visible = false;
            loginPanel.Visible = true;

        }
    }
}
