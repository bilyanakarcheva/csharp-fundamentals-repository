using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1 2 3 3
            //bool isThereEqualSum = false;
            //int index = 0;

            for (int i = 0; i < array.Length; i++)
            {

                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    //index = i;
                    //isThereEqualSum = true;
                    //break;
                    Console.WriteLine(i);
                    return; // the program finishes when it's met with this function
                }
            }
            //if (isThereEqualSum)
            //{
            //    Console.WriteLine(index);
            //}
            //else
            //{
                Console.WriteLine("no");
            //}
        }
    }
}
