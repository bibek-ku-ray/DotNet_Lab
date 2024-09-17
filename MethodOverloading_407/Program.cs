using System;

namespace MethodOverloading_407
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(int a, double b)
        {
            return a + b;
        }

        public double Add(double a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum of 5 and 10 (int): " + calc.Add(5, 10));
            Console.WriteLine("Sum of 5, 10, and 15 (int): " + calc.Add(5, 10, 15));
            Console.WriteLine("Sum of 5.5 and 3.2 (double): " + calc.Add(5.5, 3.2));
            Console.WriteLine("Sum of 5 and 3.5 (int and double): " + calc.Add(5, 3.5));
            Console.WriteLine("Sum of 3.5 and 5 (double and int): " + calc.Add(3.5, 5));
            Console.ReadLine();
        }
    }
}
