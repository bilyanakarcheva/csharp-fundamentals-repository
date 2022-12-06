using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            string[] elements = command.Split();

            while (command != "end")
            {

                if (elements[0] == "Delete")
                {

                    DeleteElement(list, elements);

                }
                else if (elements[0] == "Insert")
                {

                    InsertElement(list, elements);

                }

                command = Console.ReadLine(); // Пропускам
                elements = command.Split(); // Пропускам
            }

            Console.WriteLine(string.Join(" ", list));

        }

        static void DeleteElement(List<int> list, string[] elements)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == int.Parse(elements[1]))
                {

                    list.Remove(int.Parse(elements[1]));
                    i -= 1; // Пропускам

                }
            }
        }

        static void InsertElement(List<int> list, string[] elements)
        {
            list.Insert(int.Parse(elements[2]), int.Parse(elements[1]));
        }
    }
}
