using System;

namespace ArrayAsParameters_407
{
    class Program
    {
        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            double average = (double)sum / numbers.Length;
            return average;
        }

        static void DisplayArray(int[] numbers)
        {
            Console.WriteLine("Array Elements:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] myArray = { 10, 20, 30, 40, 50 };

            DisplayArray(myArray);

            int sum = CalculateSum(myArray);
            double average = CalculateAverage(myArray);

            Console.WriteLine($"Sum of array elements: {sum}");
            Console.WriteLine($"Average of array elements: {average}");
            Console.ReadLine();
        }
    }
}
