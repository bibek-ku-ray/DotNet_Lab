using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightLeftShift_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;

            int leftShift = number << 2; 
            int rightShift = number >> 2;

            Console.WriteLine("Bitwise Shift Operations:");
            Console.WriteLine($"Original number: {number} (Binary: {Convert.ToString(number, 2).PadLeft(8, '0')})");
            Console.WriteLine($"After left shift by 2: {leftShift} (Binary: {Convert.ToString(leftShift, 2).PadLeft(8, '0')})");
            Console.WriteLine($"After right shift by 2: {rightShift} (Binary: {Convert.ToString(rightShift, 2).PadLeft(8, '0')})");
            Console.ReadLine();
        }
    }
}
