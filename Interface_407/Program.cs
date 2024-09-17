using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_407
{
    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);

            Console.WriteLine("Circle:");
            Console.WriteLine("Area: " + circle.CalculateArea());
            Console.WriteLine("Perimeter: " + circle.CalculatePerimeter());

            Console.WriteLine("\nRectangle:");
            Console.WriteLine("Area: " + rectangle.CalculateArea());
            Console.WriteLine("Perimeter: " + rectangle.CalculatePerimeter());
            Console.ReadLine();
        }
    }
}
