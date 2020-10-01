using System;
using System.Text.RegularExpressions;

namespace Task5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter an HTML text: ");
            string str = Console.ReadLine();
            string newString = Regex.Replace(str, "<[^>]*>", "_");
            Console.WriteLine($"Modified string: {newString}");
        }
    }
}