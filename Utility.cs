using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ATMMachine
{
    class Utility
    {
    }
    /// <summary>
    /// Database Utility class contains methods that interact with the database
    /// </summary>
    class DatabaseUtility
    {
        public DatabaseUtility()
        {
        }
        /// <summary>
        /// validates account number and pin
        /// </summary>
        /// <param name="card">4 digit card number</param>
        /// <param name="pin">4 digit pin</param>
        /// <returns></returns>

        public bool loginValidation(string card, string pin)
        {
            //initialize variables
            int cardnum;
            int pinnum;
            int testpin=0;
            int.TryParse(card, out cardnum);
            int.TryParse(pin, out pinnum);
            Boolean validated = false;

            //connection string to Coleman db
            string connectionString = @"";

            //instantiates connection connection
            SqlConnection conn = new SqlConnection(connectionString);
            

            try
            {
                //opens db connection
                conn.Open();
                //calls the command
                SqlCommand cmd = new SqlCommand("retrievePINInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //adds first parameter
                SqlParameter theCard = new SqlParameter("@cardNum", SqlDbType.Int);
                theCard.Value = cardnum;
                theCard.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(theCard);
                //adds output parameter
                SqlParameter returnPin = new SqlParameter("@thePIN", SqlDbType.Int);
                returnPin.Size = 4;
                returnPin.Direction = ParameterDirection.Output; // This is important!
                cmd.Parameters.Add(returnPin);
                cmd.ExecuteNonQuery();
                try
                {
                    //sets pin value to return value
                    testpin = (int)returnPin.Value;
                }
                catch (InvalidCastException ice)
                {
                    testpin = 0;
                }
                catch (Exception e)
                {
                    testpin = 0;
                }
                //close connection
                conn.Close();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.ToString());
            }
            finally
            {
                if (testpin == pinnum)
                {
                    //if pin entered matches pin submitted, returns a true value for boolean
                    validated = true;
                }
                else
                {
                    
                    validated = false;
                }
            }
            return validated;
        }
        /// <summary>
        /// Returns Customer Number from the database after the card number and pin have been verified
        /// </summary>
        /// <param name="card">card value entered by the user</param>
        /// <param name="pin">pin value entered by the user</param>
        /// <returns></returns>
        public int getCustomerNumber(string card, string pin)
        {
            //initializes variables
            int cardNum;
            int pinNum;
            int accountNum=0;
            //parses string values into ints to interact with program
            int.TryParse(card, out cardNum);
            int.TryParse(pin, out pinNum);
            //opens connection string for db connection
            string connectionString = @"";
            //instantiates the connection
            SqlConnection conn = new SqlConnection(connectionString);
            

            try
            {
                //opens connection
                conn.Open();

                //selects the stored procedure from the db to get the customer number
                SqlCommand cmd = new SqlCommand("getAccount", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //first input parameter
                SqlParameter theCard = new SqlParameter("@card", SqlDbType.Int);
                theCard.Value = cardNum;
                theCard.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(theCard);

                //second input parameter
                SqlParameter thePin = new SqlParameter("@pin", SqlDbType.Int);
                thePin.Value = pinNum;
                thePin.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(thePin);

                //return parameter
                SqlParameter custNum = new SqlParameter("@acctNum", SqlDbType.Int);
                custNum.Size = 6;
                custNum.Direction = ParameterDirection.Output; // This is important!
                cmd.Parameters.Add(custNum);
                cmd.ExecuteNonQuery();
                  accountNum = (int)custNum.Value;
                
                
                conn.Close();
                

            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.ToString());
            }
            return accountNum;

        }
       /// <summary>
       /// Retrieves a data table with relevant account information, specifically the customer name and account number to be used later
       /// </summary>
       /// <param name="custID">customer ID number retrived earlier</param>
       /// <param name="acctType">account type selected by the user</param>
       /// <returns></returns>
        public DataTable accountInformation(int custID, char acctType)
        {
            //initializes the connection string
            string connectionString = "";
            SqlConnection conn = new SqlConnection(connectionString);
            //initializes the data table
            DataTable custData = new DataTable();
            //executes the stored procedure
            SqlDataAdapter a = new SqlDataAdapter("getCustomerInformation", conn);
            a.SelectCommand.CommandType = CommandType.StoredProcedure;
            a.SelectCommand.Parameters.Add("@custID", SqlDbType.Int);
            a.SelectCommand.Parameters["@custID"].Value = custID;
            a.SelectCommand.Parameters.Add("@acctType", SqlDbType.Char);
            a.SelectCommand.Parameters["@acctType"].Value = acctType;

            try
            {
                using (conn)
                {
                    conn.Open();
                    using (a)
                    {
                        //fills the data table
                        a.Fill(custData);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return custData;
        }
        /// <summary>
        /// Submits completed deposit to database
        /// </summary>
        /// <param name="txn">the transaction object holding variables of the transaction</param>
        public void makeDeposit(Transaction txn)
        {
         //instantiates connection string
            string connectionString = @"";
            //initializes connection
            SqlConnection conn = new SqlConnection(connectionString);

            //initialized variables
            decimal newDepTotal;
            decimal prevDepTotal;
            

            try
            {
                //opens connection
                conn.Open();
                //the stored procedure
                SqlCommand depcmd = new SqlCommand("getAllDeposits", conn);
                depcmd.CommandType = CommandType.StoredProcedure;

                //input parameter
                SqlParameter acct = new SqlParameter("@acctNum", SqlDbType.Int);
                acct.Value = txn.AcctNumber;
                acct.Direction = ParameterDirection.Input;
                depcmd.Parameters.Add(acct);
                //adds output parameter
                SqlParameter dep = new SqlParameter("@deposits", SqlDbType.Money);
                dep.Size = 12;
                dep.Direction = ParameterDirection.Output; // This is important!
                depcmd.Parameters.Add(dep);
                depcmd.ExecuteNonQuery();
                try
                {
                    //parses returned previous deposit to update separate table
                    string prevDep = dep.Value.ToString();
                    Decimal.TryParse(prevDep, out prevDepTotal);
                }
                catch (Exception e)
                {
                    prevDepTotal = 0;
                }

                //updated total deposits
                newDepTotal = txn.Amount + prevDepTotal;
                //stored procedure for submitting the deposit
                SqlCommand cmd = new SqlCommand("Deposit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@acct", SqlDbType.Int);
                cmd.Parameters["@acct"].Value = txn.AcctNumber;
                cmd.Parameters.Add("@amount", SqlDbType.Money);
                cmd.Parameters["@amount"].Value = txn.Amount;
                cmd.ExecuteNonQuery();
                //stored procedure for updating total deposit amount
                SqlCommand command = new SqlCommand("UpdateDeposittotal", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@acctNum", SqlDbType.Int);
                command.Parameters["@acctNum"].Value = txn.AcctNumber;
                command.Parameters.Add("@balance", SqlDbType.Money);
                command.Parameters["@balance"].Value = newDepTotal;
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.ToString());
            }
            finally
            {
                
            }
            
        }
        /// <summary>
        /// Submits withdrawal to database and updates all relevant tables
        /// </summary>
        /// <param name="txn">Transaciton object with all relevant information</param>
        public void makeWithdrawal(Transaction txn)
        {
            //initializes connection string
            string connectionString = @"";
            //initializes connection
            SqlConnection conn = new SqlConnection(connectionString);

            //initializes variables used for updating total deposit
            decimal prevWd;
            decimal updatedWD;


            try
            {
                conn.Open();

                //fetches all previous withdrawal amounts from database
                SqlCommand wdcmd = new SqlCommand("getAllWithdrawals", conn);
                wdcmd.CommandType = CommandType.StoredProcedure;
                //adds first parameter
                SqlParameter acct = new SqlParameter("@acctNum", SqlDbType.Int);
                acct.Value = txn.AcctNumber;
                acct.Direction = ParameterDirection.Input;
                wdcmd.Parameters.Add(acct);
                //adds output parameter
                SqlParameter wd = new SqlParameter("@wd", SqlDbType.Money);
                wd.Size = 12;
                wd.Direction = ParameterDirection.Output; // This is important!
                wdcmd.Parameters.Add(wd);
                wdcmd.ExecuteNonQuery();
                try
                {
                    //sets withdrawal value to return value
                    string wdString = wd.Value.ToString();
                    decimal.TryParse(wdString, out prevWd);
                    updatedWD = prevWd + txn.Amount;

                }
                catch(Exception)
                {
                    prevWd = 0;
                    updatedWD = txn.Amount;
                }
                //executes withdrawal
                SqlCommand cmd = new SqlCommand("Withdrawal", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@acct", SqlDbType.Int);
                cmd.Parameters["@acct"].Value = txn.AcctNumber;
                cmd.Parameters.Add("@amount", SqlDbType.Money);
                cmd.Parameters["@amount"].Value = txn.Amount;
                cmd.ExecuteNonQuery();

                //updates total withdrawals
                SqlCommand command = new SqlCommand("updateWithdrawalTotal", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@acctNum", SqlDbType.Int);
                command.Parameters["@acctNum"].Value = txn.AcctNumber;
                command.Parameters.Add("@balance", SqlDbType.Money);
                command.Parameters["@balance"].Value = updatedWD;
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.ToString());
            }
            finally
            {

            }
        }
        /// <summary>
        /// Gets balance to validate withdrawals (to prevent overdrafting) and display updated balance
        /// </summary>
        /// <param name="accountNum"></param>
        /// <returns></returns>
        public decimal getBalance(int accountNum)
        {
            //initialize variables
            decimal dep;
            decimal withdraw;
            decimal balance;


            string connectionString = @"";


            //instantiates connection connection
            SqlConnection conn = new SqlConnection(connectionString);


            try
            {
                //opens db connection
                conn.Open();
                //calls the command
                SqlCommand cmd = new SqlCommand("getAllDeposits", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //adds first parameter
                SqlParameter acctNum = new SqlParameter("@acctNum", SqlDbType.Int);
                acctNum.Value = accountNum;
                acctNum.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(acctNum);
                //adds output parameter
                SqlParameter deposits = new SqlParameter("@deposits", SqlDbType.Money);
                deposits.Size = 12;
                deposits.Direction = ParameterDirection.Output; // This is important!
                cmd.Parameters.Add(deposits);
                cmd.ExecuteNonQuery();
                try
                {
                    //sets deposit value to return value
                    string depString = deposits.Value.ToString();
                    decimal.TryParse(depString, out dep);

                }
                catch (InvalidCastException ice)
                {
                    MessageBox.Show("We apologize, there was an error with the server, please try again later");
                    dep = 0;
                }
                catch (Exception e)
                {
                    MessageBox.Show("We apologize, there was an error with the server, please try again later");
                    dep = 0;
                }

                //calls the command
                SqlCommand wdcmd = new SqlCommand("getAllWithdrawals", conn);
                wdcmd.CommandType = CommandType.StoredProcedure;
                //adds first parameter
                SqlParameter acct = new SqlParameter("@acctNum", SqlDbType.Int);
                acct.Value = accountNum;
                acct.Direction = ParameterDirection.Input;
                wdcmd.Parameters.Add(acct);
                //adds output parameter
                SqlParameter wd = new SqlParameter("@wd", SqlDbType.Money);
                wd.Size = 12;
                wd.Direction = ParameterDirection.Output; // This is important!
                wdcmd.Parameters.Add(wd);
                wdcmd.ExecuteNonQuery();
                try
                {
                    //sets pin value to return value
                    string wdString = wd.Value.ToString();
                    decimal.TryParse(wdString, out withdraw);

                }
                catch (InvalidCastException ice)
                {
                    MessageBox.Show("We apologize, there was an error with the server, please try again later");
                    withdraw = 0;
                }
                catch (Exception e)
                {
                    MessageBox.Show("We apologize, there was an error with the server, please try again later");
                    withdraw = 0;
                }
                //close connection
                conn.Close();




            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.ToString());
                dep = 0;
                withdraw = 0;
            }
            catch (Exception)
            {
                dep = 0;
                withdraw = 0;
            }
            
            balance = dep - withdraw;
           
            return balance;
        }
        
    }
    /// <summary>
    /// Utility class that does data validation prior to being submitted to the database.
    /// </summary>
    static class ATMFunction
    {
        //tests user button entry for a valid decimal value
        public static Boolean validateEntry(string desired)
        {
            bool valid=false;

            //regular expression for decimal value            
            Match match = Regex.Match(desired, @"^\d+(\.\d{1,2})?$");
            if(match.Success)
            {
                valid=true;
            }
            else
            {
                valid=false;
            }
            return valid;


        }
        /// <summary>
        /// Validates requested withdrawal amount against current balance to prevent overdraft
        /// </summary>
        /// <param name="desired">amount requested</param>
        /// <param name="balance">previous balance</param>
        /// <returns></returns>
        public static Boolean validateWithdrawal(decimal desired, decimal balance)
        {
            Boolean sufficientFunds = false;
            if (desired >= balance)
            {
                sufficientFunds = true;
            }
            return sufficientFunds;
        }
        /// <summary>
        /// Validates if withdrawal amount is divisible by 20, since machine only dispenses $20 bills
        /// </summary>
        /// <param name="desired">amount requested</param>
        /// <returns></returns>
        public static Boolean validateWithdrawalAmount(decimal desired)
        {
            Boolean divByTwenty=false;
            decimal remainder = desired % 20;
            if (remainder == 0)
            {
                divByTwenty = true;
            }
            return divByTwenty;

        }
        /// <summary>
        /// calculates updated balance
        /// </summary>
        /// <param name="txn">transaction object holding all prevous information</param>
        /// <returns></returns>
        public static decimal updatedBalance(Transaction txn)
        {
            decimal update;
            if (txn.TransactionType == 'W')
            {
                update = txn.PrevBalance - txn.Amount;
            }
            else
            {
                update = txn.PrevBalance + txn.Amount;
            }
            return update;
        }
          
        
        

    }
    /// <summary>
    /// Transaction object class to carry information through the transaction
    /// </summary>
    public class Transaction
    {
        public Transaction() { }
        private int custNumber;

        public int CustNumber
        {
            get { return custNumber; }
            set { custNumber = value; }
        }
       
        private int acctNumber;

        public int AcctNumber
        {
            get { return acctNumber; }
            set { acctNumber = value; }
        }
        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private char transactionType;

        public char TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }
        private char accountType;

        public char AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        private string custName;

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }
        private decimal prevBalance;

        public decimal PrevBalance
        {
            get { return prevBalance; }
            set { prevBalance = value; }
        }
    }
}
