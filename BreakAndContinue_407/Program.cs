using System;

namespace BreakAndContinue_407
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using 'break' statement:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Breaking the loop at i = " + i);
                    break;
                }
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine();

            Console.WriteLine("Using 'continue' statement:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("i = " + i);
            }
            Console.ReadLine();
        }
    }
}
