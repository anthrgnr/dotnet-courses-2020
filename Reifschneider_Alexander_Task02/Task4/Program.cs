using System;

namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of Triangles in a tree");
            Console.Write("n=");
            int n = Int32.Parse(Console.ReadLine());
            for (int s = 1; s <= n; s++)
            {
                for (int i = 0; i <= s - 1; i++)
                {
                    for (int k = 0; k < n - i - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= 2 * i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}