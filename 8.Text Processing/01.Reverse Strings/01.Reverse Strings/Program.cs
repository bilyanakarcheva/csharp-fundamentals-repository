﻿using System;
using System.Linq;

namespace _01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); // helLo 

            while (word != "end")
            {
                string reversed = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }
                Console.WriteLine($"{word} = {reversed}");

                word = Console.ReadLine();
            }


        }
    }
}
