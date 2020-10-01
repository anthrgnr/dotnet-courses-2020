using System;
using System.Globalization;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CultureInformation.PrintInfo("ru-RU", "en-EN");
            CultureInformation.PrintInfo("en-EN", "in");
            CultureInformation.PrintInfo("ru-RU", "in");
        }

        public static class CultureInformation
        {
            public static void PrintInfo(string firstCulture, string secondCulture)
            {
                CultureInfo info = new CultureInfo(firstCulture);
                CultureInfo info2 = new CultureInfo(secondCulture);
                Console.WriteLine("{0,-31}{1,-47}{2,-25}", "", firstCulture, secondCulture);
                Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Date/Time Format", info.DateTimeFormat.FullDateTimePattern, info2.DateTimeFormat.FullDateTimePattern);
                Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Number Decimal Separator", info.NumberFormat.NumberDecimalSeparator, info2.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Number Group Separator", info.NumberFormat.NumberGroupSeparator, info2.NumberFormat.NumberGroupSeparator + "\n");
            }
        }
    }
}