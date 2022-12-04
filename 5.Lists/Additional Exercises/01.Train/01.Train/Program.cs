namespace _01.Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input
                    .Split()
                    .ToArray();

                if (tokens[0] == "Add")
                {
                    listOfWagons.Add(int.Parse(tokens[1]));
                }
                else
                {
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        int passengers = int.Parse(tokens[0]);
                        if (listOfWagons[i] >= maxCapacity)
                        {
                            continue;
                        }
                        else if ((listOfWagons[i] + passengers) <= maxCapacity)
                        {
                            listOfWagons[i] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', listOfWagons));
        }
    }
}
