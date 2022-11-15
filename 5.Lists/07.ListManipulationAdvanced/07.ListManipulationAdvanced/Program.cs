using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool isChanged = false;

            while (command != "end")
            {

                string[] elements = command.Split();

                if (elements[0] == "Contains" || elements[0] == "PrintEven" || elements[0] == "PrintOdd" || elements[0] == "GetSum" || elements[0] == "Filter")
                {
                    ListManipulationAdvanced(numbers, elements);
                }
                else
                {
                    isChanged = true;

                    switch (elements[0])
                    {
                        case "Add":
                            numbers.Add(int.Parse(elements[1].ToString())); // Check element of string

                            break;
                        case "Remove":
                            numbers.Remove(int.Parse(elements[1].ToString()));

                            break;
                        case "RemoveAt":
                            numbers.RemoveAt(int.Parse(elements[1].ToString()));

                            break;
                        case "Insert":
                            int number = int.Parse(elements[1]);
                            int index = int.Parse(elements[2]);
                            numbers.Insert(index, number); // !!IMPORTANT!!

                            break;
                        default:
                            break;
                    }
                }

                command = Console.ReadLine();

            }
            if (isChanged)
            {

            Console.WriteLine(string.Join(" ", numbers));
            }

        }

        static void ListManipulationAdvanced(List<int> numbers, string[] elements)
        {

            switch (elements[0])
            {
                case "Contains":
                    if (numbers.Contains(int.Parse(elements[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();

                    break;
                case "PrintOdd":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();

                    break;
                case "GetSum":
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                    break;
                case "Filter":
                    int currentNumber = int.Parse(elements[2]);

                    switch (elements[1])
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < currentNumber)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();

                            break;
                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > currentNumber)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();

                            break;
                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= currentNumber)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();

                            break;
                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= currentNumber)
                                {
                                    Console.WriteLine(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();

                            break;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
