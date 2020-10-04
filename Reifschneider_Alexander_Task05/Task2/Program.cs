using System;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Circle c = new Circle(0, 0, 10);
            Console.WriteLine("Circle:");
            Console.WriteLine($"x=" + c.X + " y=" + c.Y + " R=" + c.R);
            Console.WriteLine($"l=" + c.L + " S=" + c.S);
        }
    }

    public class Circle
    {
        private double l, s;

        public int X { get; set; }
        public int Y { get; set; }
        public double R { get; set; }

        public double L
        {
            get
            {
                return 2 * R * Math.PI;
            }

            set
            {
                l = value;
            }
        }

        public double S
        {
            get
            {
                return Math.Pow(R, 2) * Math.PI;
            }

            set
            {
                s = value;
            }
        }

        public Circle(int x, int y, double r)
        {
            if (r < 0)
            {
                throw new Exception("Not valid radius");
            }
            else
            {
                R = r;
            }
            X = x;
            Y = y;
        }
    }
}