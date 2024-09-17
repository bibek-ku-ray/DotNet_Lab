using System;

namespace JaggedArraySum_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8, 9 },
            new int[] { 10 }
        };
            Console.WriteLine("Jagged Array Elements and Row Sums:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int rowSum = 0;
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                    rowSum += jaggedArray[i][j];
                }
                Console.WriteLine($"| Sum: {rowSum}");
                Console.ReadLine();
            }
        }
    }
}
