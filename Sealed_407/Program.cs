using System;
namespace Sealed_407
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    sealed class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }

        public void Fetch()
        {
            Console.WriteLine("Dog is fetching a ball");
        }
    }

    // Uncommenting the following code will result in a compilation error
    // class Bulldog : Dog
    // {
    //     // Error: 'Dog' is a sealed class and cannot be inherited
    // }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Speak();
            myDog.Fetch();
            Console.ReadLine();
        }
    }
}
