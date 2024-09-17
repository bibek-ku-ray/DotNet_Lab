using System;

namespace GenericMethod_407
{
    class Program
    {
        public static void DisplayArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            T max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] strArray = { "apple", "banana", "cherry" };

            Console.WriteLine("Integer array:");
            DisplayArray(intArray); 

            Console.WriteLine("\nString array:");
            DisplayArray(strArray); 

            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] words = { "apple", "banana", "cherry" };

            int maxNumber = FindMax(numbers);
            string maxWord = FindMax(words);

            Console.WriteLine("\nMaximum number: " + maxNumber);
            Console.WriteLine("Maximum word: " + maxWord);
            Console.ReadLine();
        }
    }
}
