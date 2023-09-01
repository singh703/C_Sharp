using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class BankAccount
        {
            private int accountNumber;
            private string accountHolderName;
            private double balance;

            public BankAccount(int accountNumber, string accountHolderName, double balance)
            {
                this.accountNumber = accountNumber;
                this.accountHolderName = accountHolderName;
                this.balance = balance;
            }

            public int AccountNumber
            {
                get { return accountNumber; }
                set { accountNumber = value; }
            }

            public string AccountHolderName
            {
                get { return accountHolderName; }
                set { accountHolderName = value; }
            }

            public double Balance
            {
                get { return balance; }
                set { balance = value; }
            }

            public void Deposit(double amount)
            {
                balance += amount;
            }

            public void Withdrawal(double amount)
            {
                if (balance < amount)
                {
                    throw new System.Exception("Insufficient balance");
                }

                balance -= amount;
            }

            public void DisplayAccountDetails()
            {
                Console.WriteLine("Account number: {0}", AccountNumber);
                Console.WriteLine("Account holder name: {0}", AccountHolderName);
                Console.WriteLine("Balance: {0:n}", Balance);
            }
        }
    }
    }
}
