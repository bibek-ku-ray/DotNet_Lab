using System;

namespace ReferenceDatatype_407
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bibek", 22);

            Person person2 = person1;

            Console.WriteLine("Before modification:");
            person1.DisplayInfo();
            person2.DisplayInfo();

            person2.Name = "Ayush";
            person2.Age = 23;

            Console.WriteLine("\nAfter modification:");
            person1.DisplayInfo();
            person2.DisplayInfo();
            Console.ReadLine();
        }
    }
}
