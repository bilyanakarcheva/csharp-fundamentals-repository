using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            ListManipulation(numbers);
        }

        static void ListManipulation(List<int> numbers)
        {

            string command = Console.ReadLine(); // Add 3

            while (command != "end")
            {
                string[] elements = command.Split();
                
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

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
