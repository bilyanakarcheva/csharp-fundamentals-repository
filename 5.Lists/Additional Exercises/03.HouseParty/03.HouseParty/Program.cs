using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> ListOfNames = new List<string>();

            string command = Console.ReadLine();
            string[] elements = command.Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray(); // !!!IMPORTANT!!!

            string name = elements[0];

            for (int i = 0; i < numberOfCommands; i++)
            {

                if (elements[2] == "going")
                {
                    AddPersonToTheList(ListOfNames, elements, name);
                }
                else if (elements[2] == "not")
                {
                    RemovePersonFromList(ListOfNames, elements, name);
                }

                command = Console.ReadLine();
                elements = command.Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                name = elements[0];
            }

            for (int i = 0; i < ListOfNames.Count; i++)
            {
                Console.WriteLine(ListOfNames[i]);
            }
        }

        static void AddPersonToTheList(List<string> ListOfNames, string[] command, string name)
        {
            if (ListOfNames.Count == 0)
            {
                ListOfNames.Add(name);
            }
            else
            {
                for (int i = 0; i < ListOfNames.Count; i++)
                {
                    if (ListOfNames[i] != name)
                    {
                        ListOfNames.Add(name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }
        }

        static void RemovePersonFromList(List<string> ListOfNames, string[] command, string name)
        {

            for (int i = 0; i < ListOfNames.Count; i++)
            {
                if (ListOfNames[i] == name)
                {
                    ListOfNames.Remove(name);
                }
            }
                if (true)
                {
                    Console.WriteLine($"{name} is not in the list!");                    
                }
                
        }
    }
}
