using System;
using System.Linq;

namespace _505.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 14 24 3 19 15 17

            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(array[i] + " ");
                }
            }


        }
    }
}
