using System;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string: ");
            string mainString = Console.ReadLine();
            Console.WriteLine("Enter the second string: ");
            string secondaryString = Console.ReadLine();
            string finalString = "";
            foreach (char c in mainString)
            {
                if (secondaryString.Contains(c))
                {
                    finalString += c;
                    finalString += c;
                }
                else
                {
                    finalString += c;
                }
            }
            Console.WriteLine($"The new string is: {finalString}");
        }
    }
}