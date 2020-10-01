using System;
using System.Text;

namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int N = 1;
            DateTime startTime = DateTime.Now;
            string str = "";
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            DateTime endTime = DateTime.Now;
            var strTime = endTime - startTime;
            Console.WriteLine($"Time used by strings adding: {strTime.TotalMilliseconds} ms");

            startTime = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            endTime = DateTime.Now;
            var strBTime = endTime - startTime;
            Console.WriteLine($"Time used by StringBuilder: {strBTime.TotalMilliseconds} ms");
            Console.WriteLine($"StringBuilder is {strTime / strBTime} times faster than string adding");
        }
    }
}