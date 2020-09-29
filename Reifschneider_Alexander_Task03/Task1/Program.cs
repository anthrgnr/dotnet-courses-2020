using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1,100);
            }
            Console.WriteLine($"The original array is ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n" + $"Min = {ArrayMethods.MinValue(array)}");
            Console.WriteLine($"Max = {ArrayMethods.MaxValue(array)}");
            int[] sortedArray = ArrayMethods.Sort(array);
            Console.WriteLine($"The sorted array is ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
        }
    }

    public static class ArrayMethods
    {
        public static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int MinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int[] Sort(int[] array)
        {
            int min;
            for (int i = 0; i < array.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                if (array[min] != array[i])
                {
                    int temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
            return array;
        }
    }
}