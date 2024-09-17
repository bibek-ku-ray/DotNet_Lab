using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectEmployeeLINQ_407
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Bibek", Address = "Kathmandu", Salary = 25000 },
            new Employee { Id = 2, Name = "Ujjwal", Address = "Lalitpur", Salary = 18000 },
            new Employee { Id = 3, Name = "Aaryan", Address = "Kathmandu", Salary = 22000 },
            new Employee { Id = 4, Name = "Sharbani", Address = "Bhaktapur", Salary = 30000 },
            new Employee { Id = 5, Name = "Sheetashma", Address = "Kathmandu", Salary = 19000 }
        };

            var result = from emp in employees
                         where emp.Salary > 20000 && emp.Address == "Kathmandu"
                         select emp;

            Console.WriteLine("Employees with salary greater than 20000 and address in Kathmandu:");
            foreach (var employee in result)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Address: {employee.Address}, Salary: {employee.Salary}");
            }
            Console.ReadLine();
        }
    }
}
