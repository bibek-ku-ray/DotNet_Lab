using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperator_407
{
    class Program
    {
        static void Main(string[] args)
        {    
            bool condition1 = true;
            bool condition2 = false;

            bool andResult = condition1 && condition2; 
            bool orResult = condition1 || condition2;  
            bool notResult = !condition1;             

            Console.WriteLine("Logical Operators Results:");
            Console.WriteLine($"condition1 AND condition2 (true && false) : {andResult}");
            Console.WriteLine($"condition1 OR condition2 (true || false)  : {orResult}");
            Console.WriteLine($"NOT condition1 (!true)                    : {notResult}");
            Console.ReadLine();
        }
    }
}
