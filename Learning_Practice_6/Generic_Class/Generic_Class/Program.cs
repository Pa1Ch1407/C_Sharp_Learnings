using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    // 1️⃣ Generic class with constraint
    public class Repository<T> where T : Employee, new()
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }
    }

    // 2️⃣ Base and Derived classes
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Salary { get; set; }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== GENERICS & DELEGATES DEMO =====\n");

            // Create a generic repository for employees
            Repository<Employee> repo = new Repository<Employee>();
            repo.Add(new Employee { Id = 101, Name = "John", Salary = 50000 });
            repo.Add(new Employee { Id = 102, Name = "Jane", Salary = 65000 });
            repo.Add(new Employee { Id = 103, Name = "David", Salary = 40000 });

            // 3️⃣ Func – calculate bonus
            Func<Employee, double> calculateBonus = emp => emp.Salary * 0.10;
            Console.WriteLine("Employee Bonuses (Func):");
            foreach (var emp in repo.GetAll())
                Console.WriteLine($"{emp.Name} → Bonus: {calculateBonus(emp)}");
            Console.WriteLine();

            // 4️⃣ Action – print employee details
            Action<Employee> printEmployee = e => Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Salary: {e.Salary}");
            Console.WriteLine("Employee Details (Action):");
            repo.GetAll().ForEach(printEmployee);
            Console.WriteLine();

            // 5️⃣ Predicate – filter high-salary employees
            Predicate<Employee> isHighSalary = e => e.Salary > 50000;
            var highPaid = repo.GetAll().FindAll(isHighSalary);

            Console.WriteLine("High Salary Employees (Predicate):");
            highPaid.ForEach(e => Console.WriteLine($"{e.Name} - {e.Salary}"));
            Console.WriteLine();

            // 6️⃣ Covariance – output direction
            IEnumerable<Manager> managers = new List<Manager>
            {
                new Manager { Id = 201, Name = "Alice", Salary = 80000, TeamSize = 5 },
                new Manager { Id = 202, Name = "Bob", Salary = 90000, TeamSize = 8 }
            };

            // Covariance allows assigning derived (Manager) to base (Employee)
            IEnumerable<Employee> empList = managers;
            Console.WriteLine("Managers (Covariance):");
            foreach (var e in empList)
                Console.WriteLine($"{e.Name} (Salary: {e.Salary})");
            Console.WriteLine();

            // 7️⃣ Contravariance – input direction
            Action<object> logAction = obj => Console.WriteLine($"Logging: {obj}");
            Action<string> messageAction = logAction; // Contravariance in Action<in T>
            messageAction("Report generated successfully.");

            Console.WriteLine("\n===== END OF DEMO =====");
        }
    } 
}
