using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public static class SQLHelper
    {

        /// <summary>
        /// Gets and returns the checking account number by using the Customer Id
        /// </summary>
        /// <param name="Id">The customer Id</param>
        /// <returns> Checking account number </returns>
        public static int getchecknumber(int Id)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [CheckingAccountNumber] FROM [BankCustomer] WHERE [CustomerNumber] = " + Id, con);

            int checknumber = Convert.ToInt32(command.ExecuteScalar());

            checknumber = System.Math.Abs(checknumber);
            return checknumber;
        }

        /// <summary>
        /// Gets and returns the savings account number by using the Customer Id
        /// </summary>
        /// <param name="Id"> The customer Id </param>
        /// <returns> Savings account number </returns>
        public static int getsavenumber(int Id)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [SavingsAccountNumber] FROM [BankCustomer] WHERE [CustomerNumber] = " + Id, con);

            int savingsnumber = Convert.ToInt32(command.ExecuteScalar());

            savingsnumber = System.Math.Abs(savingsnumber);
            return savingsnumber;
        }

        /// <summary>
        /// Returns a string of the account balances to update the listBoxes
        /// </summary>
        /// <param name="savenumber"> The savings account number </param>
        /// <param name="checknumber"> The checking account number </param>
        /// <returns> A string with the checking account and savings account balances </returns>
        public static string Update(int savenumber, int checknumber)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + savenumber, con);

            decimal savebalance = Convert.ToDecimal(command.ExecuteScalar());

            savebalance = System.Math.Abs(savebalance);
            con.Close();

            con.Open();
            SqlCommand comm = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + checknumber, con);

            decimal checkbalance = Convert.ToDecimal(comm.ExecuteScalar());

            checkbalance = System.Math.Abs(checkbalance);
            con.Close();
            string update = String.Format("{0,1} {1,16}", checkbalance, savebalance);

            return update;
        }

        /// <summary>
        /// Withdraws money from savings account
        /// </summary>
        /// <param name="amount">The amount to be withdrawn</param>
        /// <param name="account">The account number</param>
        public static void WithdrawSavings(decimal amount, int account)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + account, con);

            decimal balance = Convert.ToDecimal(command.ExecuteScalar());

            balance = System.Math.Abs(balance);
            con.Close();
            decimal newbalance = 0;
            if (amount > balance)
            {
                MessageBox.Show("You do not have enough money in your account for this");
                newbalance = balance;
            }
            else
            {
                newbalance = balance - amount;
            }
            con.Open();
            SqlCommand com1 = new SqlCommand("UPDATE [Account] SET [Balance] = " + newbalance + " WHERE [AccountNumber] = " + account, con);
            com1.ExecuteNonQuery();
        }

        /// <summary>
        /// Withdraws a certain amount of money from the Checking account
        /// </summary>
        /// <param name="amount">AMount to be withdrawn</param>
        /// <param name="checkaccount">Checking account number</param>
        /// <param name="saveaccount">Savings account number</param>
        public static void WithdrawChecking(decimal amount, int checkaccount, int saveaccount)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + checkaccount, con);

            decimal balance = Convert.ToDecimal(command.ExecuteScalar());

            balance = System.Math.Abs(balance);
            con.Close();
            Checking takeout = new Checking();
            bool check = takeout.checkamount(balance, amount);
            decimal newbalance;

            if (check == true)
            {
                con.Open();
                newbalance = balance - amount;
                SqlCommand com2 = new SqlCommand("UPDATE [Account] SET [Balance] = " + newbalance + " WHERE [AccountNumber] = " + checkaccount, con);
                com2.ExecuteNonQuery();
            }
            else
            {
                newbalance = amount - balance;
                con.Open();
                SqlCommand command1 = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + saveaccount, con);
                decimal savebalance = Convert.ToDecimal(command1.ExecuteScalar());
                savebalance = Math.Abs(savebalance);
                if (savebalance > newbalance)
                {
                    decimal newsavebalance = savebalance - newbalance;
                    newbalance = 0;
                    SQLHelper.Deposit(saveaccount, newsavebalance);
                    SqlCommand com1 = new SqlCommand("UPDATE [Account] SET [Balance] = " + newsavebalance + " WHERE [AccountNumber] = " + saveaccount, con);
                    SqlCommand com2 = new SqlCommand("UPDATE [Account] SET [Balance] = " + newbalance + " WHERE [AccountNumber] = " + checkaccount, con);
                    com1.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("You do not have enough funds for this. Get a job loser.");
                }
            }
        }

        /// <summary>
        /// Transfers money from one account to another
        /// </summary>
        /// <param name="amount">The amount to be transferred</param>
        /// <param name="toaccount">The account that the money goes to</param>
        /// <param name="fromaccount">The account where the amount comes from</param>
        public static void Transfer(decimal amount, int toaccount, int fromaccount)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + fromaccount, con);

            decimal frombalance = Convert.ToDecimal(command.ExecuteScalar());

            frombalance = System.Math.Abs(frombalance);
            con.Close();
            decimal newbalance = 0;
            con.Open();
            SqlCommand command1 = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + toaccount, con);

            decimal tobalance = Convert.ToDecimal(command1.ExecuteScalar());
            con.Close();
            tobalance = Math.Abs(tobalance);

            if (amount > frombalance)
            {
                MessageBox.Show("You do not have enough money in your account for this");
                newbalance = frombalance;
            }
            else
            {
                newbalance = frombalance - amount;
                tobalance = amount + tobalance;
            }
            con.Open();
            SqlCommand com1 = new SqlCommand("UPDATE [Account] SET [Balance] = " + newbalance + " WHERE [AccountNumber] = " + fromaccount, con);
            SqlCommand com2 = new SqlCommand("UPDATE [Account] SET [Balance] = " + tobalance + " WHERE [AccountNumber] = " + toaccount, con);
            com1.ExecuteNonQuery();
            com2.ExecuteNonQuery();
        }

        /// <summary>
        /// Deposits a certain amount of money into any account
        /// </summary>
        /// <param name="account">The account number</param>
        /// <param name="amount">The amount to be deposited</param>
        public static void Deposit(int account, decimal amount)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [Balance] FROM [Account] WHERE [AccountNumber] = " + account, con);
            decimal balance = Convert.ToDecimal(command.ExecuteScalar());
            amount = amount + balance;
            SqlCommand com = new SqlCommand("UPDATE [Account] SET [Balance] = " + amount + " WHERE [AccountNumber] = " + account, con);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
