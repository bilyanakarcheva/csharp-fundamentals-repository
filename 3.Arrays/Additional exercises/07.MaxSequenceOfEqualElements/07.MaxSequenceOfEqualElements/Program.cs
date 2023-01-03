using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 2 1 1 2 3 3 2 2 2 1
            int maxLength = 0;
            int lengthCounter = 1;

            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    lengthCounter++;
                }
                else
                {
                    lengthCounter = 1;
                    start = i;
                }


                if (lengthCounter > maxLength)
                {
                    maxLength = lengthCounter;
                    bestStart = start;
                }
            }


            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write(array[i] + " ");
            }
        
        }
    }
}
