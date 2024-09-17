using System;

namespace BaseKeyword_407
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Animal constructor called");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name) 
        {
            Breed = breed;
            Console.WriteLine("Dog constructor called");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Dog barks");
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Breed: " + Breed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Buddy", "Golden Retriever");
            myDog.Speak();
            myDog.ShowDetails();
            Console.ReadLine();
        }
    }
}
