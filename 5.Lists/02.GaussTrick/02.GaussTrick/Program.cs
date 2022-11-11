using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split() //On default splits by space
                .Select(int.Parse) //we should parse the elements of the list in the correct format
                .ToList(); 
            SumNumbersInList(numbers);

        }

        static void SumNumbersInList(List<int> numbers)
        {

            int originalLength = numbers.Count;
            int numOfLoops = originalLength / 2;

            for (int i = 0; i < numOfLoops / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));

        }

    }
}
