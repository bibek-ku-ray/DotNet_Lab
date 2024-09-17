using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingPlus_407
{
    class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector1 = new Vector2D(1, 2);
            Vector2D vector2 = new Vector2D(3, 4);

            Vector2D result = vector1 + vector2;

            Console.WriteLine("Vector 1: " + vector1);
            Console.WriteLine("Vector 2: " + vector2);
            Console.WriteLine("Sum of Vector 1 and Vector 2: " + result);
            Console.ReadLine();
        }
    }
}
