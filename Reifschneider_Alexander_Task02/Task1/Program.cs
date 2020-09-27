using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter sides of rectangle");
            Console.Write("a=");
            try
            {
                a = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Type int numbers!");
            }
            Console.Write("b=");
            try
            {
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Type int numbers!");
            }
            Console.WriteLine("Square equals " + Calculator.Square(a, b));
        }
    }

    public class Calculator
    {
        public static int Square(int a, int b)
        {
            return a * b;
        }
    }
}