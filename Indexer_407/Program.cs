using System;
namespace Indexer_407
{
    class StringCollection
    {
        private string[] _items;

        public StringCollection(int size)
        {
            _items = new string[size];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _items.Length)
                {
                    return _items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
            }
            set
            {
                if (index >= 0 && index < _items.Length)
                {
                    _items[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in the collection:");
            for (int i = 0; i < _items.Length; i++)
            {
                Console.WriteLine($"Index {i}: {_items[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringCollection collection = new StringCollection(5);

            collection[0] = "Apple";
            collection[1] = "Banana";
            collection[2] = "Cherry";
            collection[3] = "Date";
            collection[4] = "Elderberry";

            collection.DisplayItems();

            Console.WriteLine();
            Console.WriteLine("Item at index 2: " + collection[2]);
            Console.ReadLine();
        }
    }
}
