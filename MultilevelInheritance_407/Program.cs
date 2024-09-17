using System;

namespace MultilevelInheritance_407
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Employee : Person
    {
        public string EmployeeID { get; set; }

        public Employee(string name, int age, string employeeID)
            : base(name, age)
        {
            EmployeeID = employeeID;
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Employee ID: {EmployeeID}");
        }
    }
    class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, int age, string employeeID, string department)
            : base(name, age, employeeID)
        {
            Department = department;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Department: {Department}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Ayush", 35, "M123", "Sales");

            manager.DisplayManagerInfo();

            Console.ReadLine();
        }
    }
}
