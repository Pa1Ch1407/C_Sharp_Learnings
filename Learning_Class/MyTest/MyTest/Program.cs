using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    public class TempSenSor
    {
        public event Action<int> HighTemp;
        public void Check(int temp)
        {
            if(temp>100)
            {
                HighTemp?.Invoke(temp);
            }
        }
    }
    class Program
    {
        static void Main()
        {

            TempSenSor senSor = new TempSenSor();
            senSor.HighTemp += temp =>
            {
                Console.WriteLine("Warning! Temp is:" + temp);
            };
            senSor.Check(30);
        }
    }
}
