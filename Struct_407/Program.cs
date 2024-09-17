using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_407
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }

        public double DistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 4);

            point1.Display();

            Console.WriteLine($"Distance from origin: {point1.DistanceFromOrigin()}");

            Point point2 = point1; 
            point2.X = 10; 

            Console.WriteLine("\nAfter modifying point2:");
            point1.Display();
            point2.Display();
            Console.ReadLine();
        }
    }
}
