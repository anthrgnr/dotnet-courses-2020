using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of lines in a pyramide");
            Console.Write("n=");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= n - 1; i++)
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
