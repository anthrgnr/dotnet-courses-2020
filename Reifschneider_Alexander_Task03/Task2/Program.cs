using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] array = new int[2, 2, 2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(-100, 100);
                    }
                }
            }
            Console.WriteLine($"The original array is ");
            Print(array);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                            array[i, j, k] = 0;
                    }
                }
            }
            Console.WriteLine("\n" + "The new array is ");
            Print(array);
        }

        public static void Print(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }
        }
    }
}
