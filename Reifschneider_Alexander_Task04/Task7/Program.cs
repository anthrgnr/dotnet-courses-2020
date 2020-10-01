using System;
using System.Text.RegularExpressions;

namespace Task7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 0;
            Regex regex = new Regex(@"(([0,1]?[0-9])|(2[0-3])):[0-5][0-9]");
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    n++;
            }
            Console.WriteLine($"Time appears at text {n} times");
        }
    }
}