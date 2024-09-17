using System;
namespace ComparisonOperatorsOverloading_407
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.DistanceFromOrigin() < p2.DistanceFromOrigin();
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.DistanceFromOrigin() > p2.DistanceFromOrigin();
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return p1.DistanceFromOrigin() <= p2.DistanceFromOrigin();
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return p1.DistanceFromOrigin() >= p2.DistanceFromOrigin();
        }

        private double DistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public override bool Equals(object obj)
        {
            if (obj is Point other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
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
            Point point1 = new Point(3, 4);
            Point point2 = new Point(5, 12);

            Console.WriteLine($"Point1: {point1}");
            Console.WriteLine($"Point2: {point2}");

            Console.WriteLine($"Point1 == Point2: {point1 == point2}");
            Console.WriteLine($"Point1 != Point2: {point1 != point2}");
            Console.WriteLine($"Point1 < Point2: {point1 < point2}");
            Console.WriteLine($"Point1 > Point2: {point1 > point2}");
            Console.WriteLine($"Point1 <= Point2: {point1 <= point2}");
            Console.WriteLine($"Point1 >= Point2: {point1 >= point2}");
            Console.ReadLine();
        }
    }
}
