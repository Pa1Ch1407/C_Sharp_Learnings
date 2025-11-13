using System;
using System.Collections;


namespace CompanyManagement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== COMPANY MANAGEMENT SYSTEM =====\n");

            // 1️⃣ ArrayList – Store mixed employee data (Name, ID, Salary)
            ArrayList employeeDetails = new ArrayList();
            employeeDetails.Add("John");
            employeeDetails.Add(101);
            employeeDetails.Add(55000.75);
            employeeDetails.Add("Jane");
            employeeDetails.Add(102);
            employeeDetails.Add(62000.50);

            Console.WriteLine("1️⃣ Employee Details (ArrayList):");
            for (int i = 0; i < employeeDetails.Count; i += 3)
            {
                Console.WriteLine($"Name: {employeeDetails[i]}, ID: {employeeDetails[i + 1]}, Salary: {employeeDetails[i + 2]}");
            }
            Console.WriteLine();

            // 2️⃣ Hashtable – Store employee ID and department
            Hashtable empDepartments = new Hashtable();
            empDepartments.Add(101, "HR");
            empDepartments.Add(102, "IT");
            empDepartments.Add(103, "Finance");

            Console.WriteLine("2️⃣ Employee Departments (Hashtable):");
            foreach (DictionaryEntry entry in empDepartments)
            {
                Console.WriteLine($"EmpID: {entry.Key}, Department: {entry.Value}");
            }
            Console.WriteLine();

            // 3️⃣ Queue – Represent a printing queue for employees
            Queue printQueue = new Queue();
            printQueue.Enqueue("Employee Report - John");
            printQueue.Enqueue("Employee Report - Jane");
            printQueue.Enqueue("Employee Report - Smith");

            Console.WriteLine("3️⃣ Printing Queue (Queue):");
            while (printQueue.Count > 0)
            {
                Console.WriteLine($"Printing: {printQueue.Dequeue()}");
            }
            Console.WriteLine();

            // 4️⃣ Stack – Represent last visited pages (like navigation history)
            Stack pageHistory = new Stack();
            pageHistory.Push("Dashboard");
            pageHistory.Push("Employee List");
            pageHistory.Push("Employee Details");

            Console.WriteLine("4️⃣ Page Navigation History (Stack):");
            while (pageHistory.Count > 0)
            {
                Console.WriteLine($"Back to: {pageHistory.Pop()}");
            }
            Console.WriteLine();

            // 5️⃣ SortedList – Store product IDs and names (auto sorted)
            SortedList productList = new SortedList();
            productList.Add(3, "Keyboard");
            productList.Add(1, "Monitor");
            productList.Add(2, "Mouse");

            Console.WriteLine("5️⃣ Company Products (SortedList - Sorted by Product ID):");
            foreach (DictionaryEntry entry in productList)
            {
                Console.WriteLine($"ProductID: {entry.Key}, ProductName: {entry.Value}");
            }

            Console.WriteLine("\n===== END OF DEMO =====");
        }
    }
}
