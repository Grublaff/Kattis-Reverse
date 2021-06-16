using System;
using System.Collections.Generic;

namespace Kattis_Reverse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(Int32.Parse(Console.ReadLine()));
            }
            numbers.Reverse();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}