using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 100);
            }
            Console.WriteLine($"The original array is ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
                sum += array[i];
            }
            Console.WriteLine("\n" + $"The sum is {sum}");
        }
    }
}
