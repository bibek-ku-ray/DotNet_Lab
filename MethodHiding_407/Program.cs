using System;

namespace MethodHiding_407
{
    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display from BaseClass");
        }

        public new void Show()
        {
            Console.WriteLine("Show from BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("Display from DerivedClass");
        }

        public new void Show()
        {
            Console.WriteLine("Show from DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            BaseClass derivedAsBase = new DerivedClass();
            DerivedClass derivedObj = new DerivedClass();

            baseObj.Display(); 
            baseObj.Show();    

            derivedAsBase.Display();
            derivedAsBase.Show();  

            derivedObj.Display(); 
            derivedObj.Show();
            Console.ReadLine();
        }
    }
}
