using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOPExample
{
    // 🔹 1. Abstract class - defines a general template for all bank accounts
    public abstract class BankAccount
    {
        // 🔹 Private fields (Encapsulation)
        private string accountNumber;
        private string accountHolderName;
        private double balance;

        // 🔹 Static member (shared across all objects)
        public static int TotalAccounts = 0;

        // 🔹 Constructor
        public BankAccount(string accNumber, string holderName, double initialBalance)
        {
            accountNumber = accNumber;
            accountHolderName = holderName;
            balance = initialBalance;
            TotalAccounts++;
        }

        // 🔹 Public methods (Encapsulation via getters/setters)
        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public string GetAccountHolderName()
        {
            return accountHolderName;
        }

        public double GetBalance()
        {
            return balance;
        }

        protected void SetBalance(double newBalance)
        {
            balance = newBalance;
        }

        // 🔹 Abstract method (Abstraction — only declaration, not implementation)
        public abstract void CalculateInterest();

        // 🔹 Virtual method (for Polymorphism)
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("----- Account Details -----");
            Console.WriteLine($"Account Number   : {accountNumber}");
            Console.WriteLine($"Account Holder   : {accountHolderName}");
            Console.WriteLine($"Current Balance  : {balance}");
        }

        // 🔹 Common methods
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"✅ {amount} deposited successfully. New balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
                Console.WriteLine("❌ Insufficient funds!");
            else
            {
                balance -= amount;
                Console.WriteLine($"✅ {amount} withdrawn successfully. Remaining balance: {balance}");
            }
        }

        public static void DisplayTotalAccounts()
        {
            Console.WriteLine($"🏦 Total Accounts Created: {TotalAccounts}");
        }
    }

    // 🔹 2. Derived Class - Savings Account (Inheritance)
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        // Constructor - calls base class constructor
        public SavingsAccount(string accNumber, string holderName, double initialBalance, double rate)
            : base(accNumber, holderName, initialBalance)
        {
            interestRate = rate;
        }

        // 🔹 Implement abstract method (Abstraction)
        public override void CalculateInterest()
        {
            double interest = GetBalance() * (interestRate / 100);
            SetBalance(GetBalance() + interest);
            Console.WriteLine($"💰 Interest of {interest} added. New Balance: {GetBalance()}");
        }

        // 🔹 Override method (Polymorphism)
        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type     : Savings");
            Console.WriteLine($"Interest Rate    : {interestRate}%");
            Console.WriteLine("---------------------------");
        }
    }

    // 🔹 3. Derived Class - Current Account (Inheritance + Polymorphism)
    public class CurrentAccount : BankAccount
    {
        private double overdraftLimit;

        public CurrentAccount(string accNumber, string holderName, double initialBalance, double overdraft)
            : base(accNumber, holderName, initialBalance)
        {
            overdraftLimit = overdraft;
        }

        // 🔹 Implement abstract method
        public override void CalculateInterest()
        {
            Console.WriteLine("No interest for current account.");
        }

        // 🔹 Override Withdraw method for overdraft feature
        public new void Withdraw(double amount)
        {
            double available = GetBalance() + overdraftLimit;
            if (amount > available)
                Console.WriteLine("❌ Transaction failed! Overdraft limit exceeded.");
            else
            {
                SetBalance(GetBalance() - amount);
                Console.WriteLine($"✅ {amount} withdrawn successfully (with overdraft). Remaining balance: {GetBalance()}");
            }
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type     : Current");
            Console.WriteLine($"Overdraft Limit  : {overdraftLimit}");
            Console.WriteLine("---------------------------");
        }
    }

    // 🔹 4. Program Execution
    class Program
    {
        static void Main(string[] args)
        {
            // Create Savings Account
            SavingsAccount acc1 = new SavingsAccount("SAV001", "Pavan", 10000, 5.0);
            acc1.DisplayAccountInfo();
            acc1.Deposit(2000);
            acc1.CalculateInterest();
            acc1.Withdraw(3000);

            Console.WriteLine();

            // Create Current Account
            CurrentAccount acc2 = new CurrentAccount("CUR001", "Ravi", 5000, 2000);
            acc2.DisplayAccountInfo();
            acc2.Withdraw(6000); // within overdraft
            acc2.CalculateInterest();

            Console.WriteLine();

            // Static Member Demonstration
            BankAccount.DisplayTotalAccounts();
        }
    }
}
