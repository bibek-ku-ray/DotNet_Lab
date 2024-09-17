using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_407
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            int first = 0, second = 1;

            Console.WriteLine("Fibonacci Series:");

            Console.Write(first + " " + second + " ");

            for (int i = 2; i < terms; i++)
            {
                int next = first + second;
                Console.Write(next + " ");
                first = second; 
                second = next; 
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
