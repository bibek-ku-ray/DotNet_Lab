using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAddSubtract_407
{
    delegate int Operation(int x, int y);
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Operation addOperation = new Operation(Add);
            Operation subtractOperation = new Operation(Subtract);

            int num1 = 10;
            int num2 = 5;

            int resultAdd = addOperation(num1, num2);
            Console.WriteLine("Addition of {0} and {1} is: {2}", num1, num2, resultAdd);

            int resultSubtract = subtractOperation(num1, num2);
            Console.WriteLine("Subtraction of {0} and {1} is: {2}", num1, num2, resultSubtract);
            Console.ReadLine();
        }
    }
}
