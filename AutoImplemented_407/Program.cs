using System;

namespace AutoImplemented_407
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                ID = 1,
                Name = "Bidur",
                Age = 23
            };

            person.DisplayInfo();
            Console.ReadLine();
        }
    }
}
