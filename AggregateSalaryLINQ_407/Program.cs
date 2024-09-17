using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateSalaryLINQ_407
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee("Ayush", 45000),
            new Employee("Sameer", 55000),
            new Employee("Rusis", 30000),
            new Employee("Pramod", 50000),
            new Employee("Bharat", 60000)
        };

            decimal totalSalary = employees.Sum(emp => emp.Salary);
            Console.WriteLine($"Total Aggregate Salary of all employees: {totalSalary}\n");

            var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);

            Console.WriteLine("Employee Records (Sorted by Salary in Descending Order):");
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
            }
            Console.ReadLine();
        }
    }
}
