using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Encapsulation is bundling data and methods of private classes so users can easily interface with them
//in a public setting 

namespace ConsoleApp1.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance; //can't be accessed outside this class

        public decimal GetBalance() //Get method so user can see private field
        {
            return balance;
        }

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) //prevents user from depositing negative amount of money
            {
                throw new ArgumentException("Amount must be positive.");
            }

            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) //prevents user from depositing negative amount of money
            {
                throw new ArgumentException("Withdraw amount must be positive.");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            this.balance -= amount;
        }
    }
}