using System;

namespace StringSplitMethod_407
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Dot.Net Lab work Chapter 2";

            string[] words = sentence.Split(' ');

            Console.WriteLine("Words in the sentence:");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string[] wordsWithDot = sentence.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nWords in the sentence (split by space and dot):");
            foreach (string word in wordsWithDot)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
