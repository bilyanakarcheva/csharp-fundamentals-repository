namespace _07.ListManipulationAdvancedV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {

                string[] action = command.Split();
                List<int> currentNumbers = new List<int>();

                switch (action[0])
                {
                    case "Contains":
                        if (numbers.Contains(int.Parse(action[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        };
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                currentNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(String.Join(' ', currentNumbers));
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                currentNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(String.Join(' ', currentNumbers));
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
                        switch (action[1])
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < int.Parse(action[2]))
                                    {
                                        currentNumbers.Add((int)numbers[i]);
                                    }
                                }
                                Console.WriteLine(String.Join(' ', currentNumbers));

                                break;
                            case ">":
                                for (int i = 0;i < numbers.Count; i++)
                                {
                                    if (numbers[i] > int.Parse(action[2]))
                                    {
                                        currentNumbers.Add(numbers[i]);
                                    }
                                }
                                Console.WriteLine(String.Join(' ', currentNumbers));

                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= int.Parse(action[2]))
                                    {
                                        currentNumbers.Add(numbers[i]);
                                    }
                                }
                                Console.WriteLine(String.Join(' ', currentNumbers));

                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= int.Parse(action[2]))
                                    {
                                        currentNumbers.Add(numbers[1]);
                                    }
                                }
                                Console.WriteLine(String.Join(' ', currentNumbers));
                                break;
                        }
                        break;

                }

                command = Console.ReadLine();
            }
        }
    }
}
