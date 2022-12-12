using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            string[] operation = command.Split();

            while (command != "End")
            {
                switch (operation[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(operation[1]));
                        break;
                    case "Insert":
                        if (int.Parse(operation[2]) < 0 || int.Parse(operation[2]) > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        int index = int.Parse(operation[2]);
                        int number = int.Parse(operation[1]);
                        numbers.Insert(index, number);
                        break;
                    case "Remove":
                        if (int.Parse(operation[1]) < 0 || int.Parse(operation[1]) > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                        numbers.RemoveAt(int.Parse(operation[1]));
                        }
                        break;
                }
                switch (operation[1])
                {                
                    case "left":
                        int firstNumber = numbers[0];
                        for (int i = 0; i < int.Parse(operation[2]); i++)
                        {
                            firstNumber = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Add(firstNumber);

                        }
                        break;
                    case "right":
                        int lastNumber = numbers[numbers.Count - 1];
                        for (int i = 0; i < int.Parse(operation[2]); i++)
                        {
                            lastNumber = numbers[numbers.Count - 1];
                            for (int j = 1; j < numbers.Count; j++)
                            {
                                numbers[numbers.Count - j] = numbers[numbers.Count - j - 1];
                            }
                            numbers.RemoveAt(0);
                            numbers.Insert(0, lastNumber);
                        }
                        break;
                }

                command = Console.ReadLine();

                operation = command.Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
