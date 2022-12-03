namespace _06.ListManipulationBasicsV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers  = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();
            string input = Console.ReadLine();

            while(input != "end")
            { 

                string[] command = input
                    .Split()
                    .ToArray();

                string action = command[0];

                switch (action)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ',numbers));
        }
    }
}
