using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i%3==0)||(i%5==0))
                    n+=i;
            }
            Console.WriteLine($"The sum of numbers under 1000 multiple of 3 or 5 equals {n}");
        }
    }
}
