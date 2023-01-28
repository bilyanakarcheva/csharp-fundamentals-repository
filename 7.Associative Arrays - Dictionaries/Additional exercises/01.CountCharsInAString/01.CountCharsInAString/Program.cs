using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string charArray = Console.ReadLine();
            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            foreach (char item in charArray)
            {
                if (countOfChars.ContainsKey(item))
                {
                    countOfChars[item] += 1; 
                }
                else
                {
                    countOfChars.Add(item, 1);
                }
            }

            foreach (var item in countOfChars)
            {
                if (item.Key == ' ')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }
        }
    }
}
