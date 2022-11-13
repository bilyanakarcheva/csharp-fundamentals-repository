using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            RemoveNegativeAndPrintInReverse(numbers);
        }

        static void RemoveNegativeAndPrintInReverse(List<int> numbers)
        {

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i -= 1;
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
