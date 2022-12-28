using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNumber = input[0];
                int secondNumber = input[1];

                if (i % 2 == 0)
                {
                    array1[i] = firstNumber;
                    array2[i] = secondNumber;
                }
                else
                {
                    array1[i] = secondNumber;
                    array2[i] = firstNumber;
                }
            }
            Console.WriteLine(String.Join(' ', array1));
            Console.WriteLine(String.Join(' ', array2));
        }
    }
}
