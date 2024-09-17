using System;

namespace MatrixDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int size = matrix.GetLength(0);

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            for (int i = 0; i < size; i++)
            {
                secondaryDiagonalSum += matrix[i, size - 1 - i];
            }

            Console.WriteLine("Matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nSum of the primary diagonal: {primaryDiagonalSum}");
            Console.WriteLine($"Sum of the secondary diagonal: {secondaryDiagonalSum}");
            Console.ReadLine();
        }
    }
}
