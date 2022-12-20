using System;
using System.Linq;

namespace _08.CondenseArrayТoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (nums.Length > 1)
            {
                int[] array = new int[nums.Length - 1];

                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = nums[i] + nums[i + 1];

                }
                nums = array;

            }

            Console.WriteLine(String.Join(' ', nums));
        }
    }
}
