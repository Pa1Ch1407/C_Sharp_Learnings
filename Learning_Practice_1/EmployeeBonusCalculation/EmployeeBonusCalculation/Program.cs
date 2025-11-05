using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBonusCalculation
{
    class Program
    {
        static void Main()
        {
            // Variables and Data Types
            string employeeName = "John";
            int yearsOfExperience = 6;
            double baseSalary = 50000;
            bool isPermanent = true;

            // Operator Example
            double bonusPercentage = (yearsOfExperience > 5 && isPermanent) ? 0.10 : 0.05;
            double totalBonus = baseSalary * bonusPercentage;

            // Control Flow Example
            if (totalBonus > 4000)
            {
                Console.WriteLine($"{employeeName} gets a high bonus of {totalBonus}");
            }
            else
            {
                Console.WriteLine($"{employeeName} gets a regular bonus of {totalBonus}");
            }

            // Loop Example
            string[] rewards = { "Certificate", "Gift Card", "Extra Leave" };
            Console.WriteLine("\nRewards:");
            foreach (string reward in rewards)
            {
                Console.WriteLine("- " + reward);
            }
        }
    }
}