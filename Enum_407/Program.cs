using System;

namespace Enum_407
{
    enum DayOfWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Wednesday;

            Console.WriteLine("Today is: " + today);

            int dayNumber = (int)today;
            Console.WriteLine("Numeric value of today: " + dayNumber);

            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Start of the work week.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Midweek day.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("End of the work week.");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Weekend!");
                    break;
                default:
                    Console.WriteLine("Unknown day.");
                    break;
            }

            Console.WriteLine("\nAll days of the week:");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }
            Console.ReadLine();
        }
    }
}
