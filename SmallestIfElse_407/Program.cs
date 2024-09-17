using System;

namespace SmallestIfElse_407
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int smallest;

            if (num1 <= num2 && num1 <= num3)
            {
                smallest = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }

            Console.WriteLine($"The smallest number is: {smallest}");
            Console.ReadLine();
        }
    }
}
