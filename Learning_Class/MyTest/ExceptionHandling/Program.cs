using System;
using System.IO;

namespace ExceptionHandling
{
    class InsufficientFundsException: Exception
    {
        public InsufficientFundsException(string message) : base(message){ }
    }
   
    class Bank
    {
        public void WithDraw(int balance, int amount)
        {
            if(balance > 0)
            {
                if (amount > balance)
                    throw new InsufficientFundsException("WithDraw Amount exceeds balance.");
            }
            
            if(balance <= 0)
                throw new InsufficientFundsException("Balance is 0.");
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                Bank bank = new Bank();
                bank.WithDraw(0, 5000);
            }
            catch(InsufficientFundsException ex)
            {
                Console.WriteLine("Transaction failed: "+ex.Message);
            }
            //try
            //{
            //    string data = File.ReadAllText("config.txt");
            //    Console.WriteLine(data);
            //}
            //catch(FileNotFoundException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Attempt to read file completed.");
            //}
        }
    }
}
