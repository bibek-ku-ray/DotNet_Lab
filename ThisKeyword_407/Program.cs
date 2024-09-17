using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword_407
{
    class Employee
    {
        private string name;
        private int id;

        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"ID: {this.id}");
        }

        public void UpdateDetails(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public Employee(string name) : this(name, 0)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Bharat", 1001);
            emp1.DisplayInfo();

            Console.WriteLine();

            emp1.UpdateDetails("Pramod", 1002);
            emp1.DisplayInfo();

            Console.WriteLine();

            Employee emp2 = new Employee("Ayush");
            emp2.DisplayInfo();

            Console.ReadLine();
        }
    }
}
