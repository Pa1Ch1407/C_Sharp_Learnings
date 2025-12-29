using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Kind_Of_Number_Logic
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Prime Number Logic
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("Given Value is Prime");
            }
            if (!IsPrime)
            {
                Console.WriteLine("Given value is not prime");
            }
        }
    }
}
