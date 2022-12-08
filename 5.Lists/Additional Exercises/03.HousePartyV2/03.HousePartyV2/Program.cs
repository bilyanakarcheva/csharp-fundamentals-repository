namespace _03.HousePartyV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            List<string> peopleGoing = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = command[0];

                if (!command.Contains("not"))
                {
                    if (peopleGoing.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        peopleGoing.Add(name);
                    }
                }
                else if (command.Contains("not"))
                {
                    if (peopleGoing.Contains(name))
                    {
                        peopleGoing.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, peopleGoing));
        }
    }
}
