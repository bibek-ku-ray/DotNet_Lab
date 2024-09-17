using System;

namespace ArithmeticOperator_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 10;

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine("Arithmetic Operations:");
            Console.WriteLine($"Sum: {num1} + {num2} = {sum}");
            Console.WriteLine($"Difference: {num1} - {num2} = {difference}");
            Console.WriteLine($"Product: {num1} * {num2} = {product}");
            Console.WriteLine($"Quotient: {num1} / {num2} = {quotient}");
            Console.WriteLine($"Remainder: {num1} % {num2} = {remainder}");
            Console.ReadLine();
        }
    }
}
