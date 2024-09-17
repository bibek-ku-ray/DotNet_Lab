using System;

namespace RelationOperator_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 10;

            bool isEqual = a == b;
            bool isNotEqual = a != b;
            bool isGreaterThan = a > b;
            bool isLessThan = a < b;
            bool isGreaterThanOrEqual = a >= b;
            bool isLessThanOrEqual = a <= b;

            Console.WriteLine("Relational Operators Results:");
            Console.WriteLine($"{a} == {b} : {isEqual}");
            Console.WriteLine($"{a} != {b} : {isNotEqual}");
            Console.WriteLine($"{a} > {b}  : {isGreaterThan}");
            Console.WriteLine($"{a} < {b}  : {isLessThan}");
            Console.WriteLine($"{a} >= {b} : {isGreaterThanOrEqual}");
            Console.WriteLine($"{a} <= {b} : {isLessThanOrEqual}");
            Console.ReadLine();
        }
    }
}
