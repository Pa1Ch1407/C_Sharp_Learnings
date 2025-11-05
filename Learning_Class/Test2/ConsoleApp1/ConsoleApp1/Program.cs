using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static int Amount = 10000;
        public class Balance
        {
            
            public virtual void Start()
            {
                Console.WriteLine("Balance is: "+Amount);
            }
        }

        public class Withdraw : Balance
        {
            int wAmont = 1500;
            public override void Start()
            {
                Amount = Amount - wAmont;
                Console.WriteLine("Balance is: "+(Amount-wAmont));
            }
        }

        public class Deposit : Balance
        {
            int dAmount = 1000;
            public override void Start()
            {
                Amount = Amount + dAmount;
                Console.WriteLine("Balance is: " + (Amount + dAmount));
            }
        }

        static void Main()
        {
            Withdraw c = new Withdraw();
            c.Start();
            Deposit b = new Deposit();
            b.Start();
        }

        

        

    }
}
