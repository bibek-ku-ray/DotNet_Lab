using System;

namespace ConditionalOperator_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;
            int num2 = 40;
            int num3 = 35;

            int largest = (num1 > num2)
                            ? (num1 > num3 ? num1 : num3)  
                            : (num2 > num3 ? num2 : num3);

            Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is: {largest}");
            Console.ReadLine();
        }
    }
}
