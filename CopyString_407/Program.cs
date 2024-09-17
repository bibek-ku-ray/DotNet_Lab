using System;

namespace CopyString_407
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = "Hello, World!";

            string copiedString = string.Copy(originalString);

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Copied String: " + copiedString);
            Console.ReadLine();
        }
    }
}
