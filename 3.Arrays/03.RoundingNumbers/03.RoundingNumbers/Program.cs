﻿using System;
using System.Globalization;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }



            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }

                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
