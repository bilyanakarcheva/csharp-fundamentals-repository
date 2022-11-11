﻿using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumberedListOfProducts(n);
        }

        static void PrintNumberedListOfProducts(int n)
        {
            List<string> listOfProducts = new List<string>();
            

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                listOfProducts.Add(currentProduct);
            }

            listOfProducts.Sort();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{listOfProducts[i-1]}");
            }

        }
    }
}
