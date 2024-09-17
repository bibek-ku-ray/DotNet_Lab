using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass_407
{
    public class GenericBox<T>
    {
        private T _value;

        public GenericBox(T value)
        {
            _value = value;
        }

        public void SetValue(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }

        public void DisplayValue()
        {
            Console.WriteLine("The value in the box is: " + _value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericBox<int> intBox = new GenericBox<int>(123);
            GenericBox<string> strBox = new GenericBox<string>("Hello, Generics!");

            intBox.DisplayValue(); 
            strBox.DisplayValue(); 

            intBox.SetValue(456);
            strBox.SetValue("Generics in C#");

            intBox.DisplayValue(); 
            strBox.DisplayValue();
            Console.ReadLine();
        }
    }
}
