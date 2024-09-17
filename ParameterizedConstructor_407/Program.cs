using System;

namespace ParameterizedConstructor_407
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Ayush", 30);
            Person person2 = new Person("Rusis", 25);

            Console.WriteLine("Person 1 Details:");
            person1.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Person 2 Details:");
            person2.DisplayInfo();
            Console.ReadLine();
        }
    }
}

