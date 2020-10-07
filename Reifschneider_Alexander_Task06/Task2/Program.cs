using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(0, 0 , 5, 10);
            Console.WriteLine("Ring data:");
            Console.WriteLine("x= " + ring.X + " y= " + ring.Y);
            Console.WriteLine("Inner radius= " + ring.InnerCircle.R + " Outer radius= " + ring.R);
            Console.WriteLine("Summary length= " + ring.SummaryL);
            Console.WriteLine("Square of ring= " + ring.RingS);
        }
    }

    public class Circle
    {
        private double l, s;

        public double X { get; set; }
        public double Y { get; set; }
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

        public Circle(double x, double y, double r)
        {
            if (r < 0)
            {
                throw new Exception("Radius is not valid");
            }
            else
            {
                R = r;
            }
            X = x;
            Y = y;
        }
    }

    public class Ring : Circle
    {
        public Circle InnerCircle { get; set; }

        public double SummaryL
        {
            get
            {
                return InnerCircle.L + L;
            }
        }
        public double RingS
        {
            get
            {
                return S - InnerCircle.S;
            }
        }

        public Ring(double x, double y, double innerRadius, double outerRadius) : base(x, y, outerRadius)
        {
            if (innerRadius < outerRadius)
            {
                InnerCircle = new Circle(x, y, innerRadius);
            }
            else
            {
                throw new Exception("Inner radius should be smaller than outer!");
            }
        }
    }
}
