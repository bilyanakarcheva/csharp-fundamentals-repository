﻿using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); // 8 

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i]  + array[j] == magicNum)
                    {
                        Console.WriteLine(array[i] + " " + array[j]);
                    }
                }
            }
        }
    }
}
