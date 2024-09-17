using System;

namespace Switch_407
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            char grade;

            switch (score)
            {
                case int n when (n >= 90):
                    grade = 'A';
                    break;
                case int n when (n >= 80):
                    grade = 'B';
                    break;
                case int n when (n >= 70):
                    grade = 'C';
                    break;
                case int n when (n >= 60):
                    grade = 'D';
                    break;
                case int n when (n >= 0):
                    grade = 'F';
                    break;
                default:
                    Console.WriteLine("Invalid score. Score must be between 0 and 100.");
                    return;
            }

            Console.WriteLine($"The grade for a score of {score} is: {grade}");
            Console.ReadLine();
        }
    }
}
