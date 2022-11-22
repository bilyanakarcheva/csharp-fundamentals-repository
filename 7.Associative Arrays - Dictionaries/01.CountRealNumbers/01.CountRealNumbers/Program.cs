using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            // Always need to check if the Key already exists first!!!

            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number)) 
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }
            foreach (var number in counts)
            {

                Console.WriteLine($"{number.Key} -> {number.Value}");

            }
        }
    }
}
