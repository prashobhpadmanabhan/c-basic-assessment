using System;
using System.Runtime.Remoting.Channels;

namespace BankAccount
{
    public class BankAccount
    {
        private int accountNumber;
        private double balance;
        private string accountHolderName;

        public  BankAccount(int accountNumber, string accountHolderName, double balance = 0.0)
        {
            if (accountNumber <= 0)
            {
                throw new ArgumentException("account number should be more than 0");
            }

            if (balance < 0)
            {
                throw new ArgumentException("balance cannot be less than 0");
            }
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }

        public void deposit(int money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("deposit should be more than 0");
              
            }
            balance += money;
            Console.WriteLine("the balance left is : " + balance);
        }

        public void withdrawal(int money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("withdraw amount should be more than 0");
            }

            if (money > balance)
            {
                throw new ArgumentException("the withdrawal amount should be less than the balance amount");
            }
            balance -= money;
            Console.WriteLine("the balance left is " + balance);
        }

        public void showAccDetails()
        {
            Console.WriteLine("The account number is :" + accountNumber);
            Console.WriteLine("the name of the account holder is :" + accountHolderName);
            Console.WriteLine("Balance amount in the account: "+ balance);
        }

    }
}   