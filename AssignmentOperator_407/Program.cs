using System;

namespace AssignmentOperator_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Initial value of a: " + a);

            a += b;
            Console.WriteLine($"a += b  => a = {a}");

            a -= b; 
            Console.WriteLine($"a -= b  => a = {a}");

            a *= b;
            Console.WriteLine($"a *= b  => a = {a}");

            a /= b;
            Console.WriteLine($"a /= b  => a = {a}");

            a %= b; 
            Console.WriteLine($"a %= b  => a = {a}");
            Console.ReadLine();
        }
    }
}
