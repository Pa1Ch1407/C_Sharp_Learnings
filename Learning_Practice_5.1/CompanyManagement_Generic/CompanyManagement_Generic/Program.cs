using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement_Generic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== COMPANY MANAGEMENT SYSTEM (GENERIC COLLECTIONS) =====\n");

            // 1️⃣ List<T> – Store employee names
            List<string> employees = new List<string> { "John", "Jane", "Mark" };
            Console.WriteLine("1️⃣ Employees (List):");
            foreach (string emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine();

            // 2️⃣ Dictionary<TKey, TValue> – Employee ID and Department
            Dictionary<int, string> empDepartments = new Dictionary<int, string>
            {
                {101, "HR"},
                {102, "IT"},
                {103, "Finance"}
            };
            Console.WriteLine("2️⃣ Employee Departments (Dictionary):");
            foreach (var entry in empDepartments)
                Console.WriteLine($"ID: {entry.Key}, Department: {entry.Value}");
            Console.WriteLine();

            // 3️⃣ Queue<T> – Print job requests
            Queue<string> printJobs = new Queue<string>();
            printJobs.Enqueue("Employee Report - John");
            printJobs.Enqueue("Employee Report - Jane");
            printJobs.Enqueue("Employee Report - Mark");

            Console.WriteLine("3️⃣ Printing Queue (Queue):");
            while (printJobs.Count > 0)
                Console.WriteLine($"Printing: {printJobs.Dequeue()}");
            Console.WriteLine();

            // 4️⃣ Stack<T> – Page navigation
            Stack<string> pageHistory = new Stack<string>();
            pageHistory.Push("Dashboard");
            pageHistory.Push("Employee List");
            pageHistory.Push("Employee Details");

            Console.WriteLine("4️⃣ Page Navigation History (Stack):");
            while (pageHistory.Count > 0)
                Console.WriteLine($"Back to: {pageHistory.Pop()}");
            Console.WriteLine();

            // 5️⃣ SortedList<TKey, TValue> – Product catalog (auto-sorted by key)
            SortedList<int, string> productList = new SortedList<int, string>
            {
                {3, "Keyboard"},
                {1, "Monitor"},
                {2, "Mouse"}
            };

            Console.WriteLine("5️⃣ Products (SortedList):");
            foreach (var item in productList)
                Console.WriteLine($"Product ID: {item.Key}, Product Name: {item.Value}");

            Console.WriteLine("\n===== END OF DEMO =====");
        }
    }
}
