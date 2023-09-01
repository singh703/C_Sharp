using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class
{
    internal class Program
    {
        public class BankAccount
        {
            private int accountNumber;
            private double balance;

            public BankAccount(int accountNumber, double balance)
            {
                this.accountNumber = accountNumber;
                this.balance = balance;
            }

            public int AccountNumber { get; set; }

            public double Balance { get; set; }
        }

        public sealed class SavingsAccount : BankAccount
        {
            private double interestRate;

            public SavingsAccount(int accountNumber, double balance, double interestRate) : base(accountNumber, balance)
            {
                this.interestRate = interestRate;
            }

            public double CalculateInterest()
            {
                return balance * interestRate;
            }

            public void ApplyInterest()
            {
                balance += CalculateInterest();
            }
        }
    }
}
