using System;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine("Triangle:");
            Console.WriteLine($"a=" + t.A + " b=" + t.B + " c=" + t.C);
            Console.WriteLine($"S=" + t.GetSquare() + " P=" + t.GetPerimeter());
        }
    }

    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (((a + b) <= c) || ((a + c) <= b) || ((c + b) <= a))
            {
                throw new Exception("That triangle is impossible");
            }
            else
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public double GetSquare()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }
    }
}