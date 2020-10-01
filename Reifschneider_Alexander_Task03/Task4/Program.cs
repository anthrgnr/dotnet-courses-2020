using System;

namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;
            Random random = new Random();
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = random.Next(1, 100);
            }
            Console.WriteLine($"The original array is ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + $"The sum of even elements is {sum}");
        }
    }
}