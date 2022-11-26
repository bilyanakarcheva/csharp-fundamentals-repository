using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;
            string synonym = string.Empty;

            Dictionary<string, List<string>> realDictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                word = Console.ReadLine();
                synonym = Console.ReadLine();

                if (!realDictionary.ContainsKey(word))
                {
                    realDictionary.Add(word, new List<string>());
                    realDictionary[word].Add(synonym);
                }
                else
                {
                    realDictionary[word].Add(synonym);
                }
            }

            foreach (var item in realDictionary)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
            }
        }
    }
}
