using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Трябва да обхождаме масива и да го презаписваме във временен масив - темп.

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            //

            for (int i = 0; i < rotations; i++)
            {
                int firstElement = array[0];

                int[] temp = new int[array.Length];

                for (int j = 1; j < array.Length; j++)
                {
                    temp[j - 1] = array[j];
                }

                temp[temp.Length - 1] = firstElement;
                array = temp;
            }

            Console.WriteLine(String.Join(' ', array));
        }
    }
}
