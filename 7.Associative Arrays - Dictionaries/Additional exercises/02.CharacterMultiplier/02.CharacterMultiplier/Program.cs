using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string str1 = input[0];
            string str2 = input[1];                  

            Console.WriteLine(CharacterMultiplierDiffLength( str1,  str2));
            
        }

        static int CharacterMultiplierDiffLength (string str1, string str2)
        {
            int shortestString = 0;
            int longestString = 0;
            int totalSum = 0;

            if (str1.Length <= str2.Length)
            {
                shortestString = str1.Length;
                longestString = str2.Length;
            }
            else
            {
                shortestString = str2.Length;
                longestString = str1.Length;

            }

            for (int i = 0; i < shortestString; i++)
            {
                totalSum += str1[i] * str2[i];
            }

            for (int i = shortestString; i < longestString; i++)
            {
                if (longestString == str2.Length)
                {
                    totalSum += str2[i];
                }
                else
                {
                    totalSum += str1[i];
                }

            }

            return totalSum;
        }
    }
}
