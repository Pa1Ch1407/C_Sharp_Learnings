using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    public class Program
    {
        public static void Main()
        {
            int num = 100, num2 = 200;
            Console.WriteLine($"The number are: number 1:{num}, number 2:{num2}");
            int temp;
            temp = num;
            num = num2;
            num2 = temp;
            Console.WriteLine($"The number are: number 1:{num}, number 2:{num2}");
        }
    }
}
