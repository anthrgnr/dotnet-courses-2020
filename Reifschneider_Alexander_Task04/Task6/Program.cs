using System;
using System.Text.RegularExpressions;

namespace Task6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Regex regexNormal = new Regex("^[-+]?[0-9]*[.,]?[0-9]+$");
            Regex regexScientific = new Regex("^[-+]?[0-9]*[.,]?[0-9]+(?:[eE][-+]?[0-9]+)?$");
            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();
            if (Regex.IsMatch(num, regexNormal.ToString(), RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The number is in a default notation");
            }
            else if (Regex.IsMatch(num, regexScientific.ToString(), RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The number is in a scientific notation");
            }
            else
            {
                Console.WriteLine("That's not a number at all!");
            }
        }
    }
}