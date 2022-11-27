using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(' ', numbers));

            }


            //List<int> numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToList();

            //if (numbers.Count <= 3)
            //{
            //    Console.WriteLine(string.Join(' ', numbers));
            //    return;
            //}

            //List<int> largest3Nums = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    int currentMax = numbers.Max();
            //    largest3Nums.Add(currentMax);
            //    numbers.Remove(currentMax);
            //}

            //Console.WriteLine(string.Join(' ', largest3Nums));

        }

    }
}
