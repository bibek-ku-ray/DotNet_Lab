using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication_407
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

            int[,] matrixB = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB)
            {
                Console.WriteLine("Matrix multiplication is not possible. The number of columns in matrix A must equal the number of rows in matrix B.");
                return;
            }

            int[,] resultMatrix = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("Result of Matrix Multiplication:");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
