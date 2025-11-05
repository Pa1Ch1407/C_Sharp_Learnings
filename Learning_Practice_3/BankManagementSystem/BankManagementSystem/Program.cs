using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    // 1️⃣ Class Definition
    public class BankAccount
    {
        // 2️⃣ Fields (Data members)
        private string accountNumber;
        private string accountHolderName;
        private double balance;

        // Static member
        public static int TotalAccounts = 0;

        // 3️⃣ Constructor (used to initialize object)
        public BankAccount(string accNumber, string holderName, double initialBalance)
        {
            accountNumber = accNumber;
            accountHolderName = holderName;
            balance = initialBalance;
            TotalAccounts++; // Increment when new account is created
        }

        public static void DisplayTotalAccounts()
        {
            Console.WriteLine($"Total Bank Accounts Created: {TotalAccounts}");
        }

        // 4️⃣ Method to Deposit Money
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited successfully. New balance: {balance}");
        }

        // 5️⃣ Method to Withdraw Money
        public void Withdraw(double amount)
        {
            if (amount > balance)
                Console.WriteLine("Insufficient funds!");
            else
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully. Remaining balance: {balance}");
            }
        }

        // 6️⃣ Method to Display Account Info
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolderName}");
            Console.WriteLine($"Current Balance: {balance}");
        }
    }

    // 🏦 Main class to run the program
    class Program
    {
        static void Main()
        {
            // Creating an object (instance) of BankAccount class
            BankAccount account1 = new BankAccount("1234567890", "Pavan", 5000);
            BankAccount.DisplayTotalAccounts(); // Static method called using class name
            account1.DisplayAccountInfo();
            account1.Deposit(1500);
            account1.Withdraw(2000);
            account1.Withdraw(6000); // insufficient funds
        }
    }
}
