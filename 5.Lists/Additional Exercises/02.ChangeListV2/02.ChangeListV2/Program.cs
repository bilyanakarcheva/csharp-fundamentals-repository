namespace _02.ChangeListV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine() //system.collection.generic
                .Split()
                .Select(int.Parse) //system.linq
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {     

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(command[1]))
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int item = int.Parse(command[1]);
                    numbers.Insert(index, item);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
