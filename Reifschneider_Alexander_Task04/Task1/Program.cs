using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string[] strings = str.Split(' ', ',', '.');
            double avglen = 0;
            int n = 0;
            foreach (string s in strings)
            {
                if (s.Length != 0)
                {
                    avglen += s.Length;
                    n++;
                }
            }
            avglen /= n;
            Console.WriteLine($"Average length of the string: {avglen}");
        }
    }
}