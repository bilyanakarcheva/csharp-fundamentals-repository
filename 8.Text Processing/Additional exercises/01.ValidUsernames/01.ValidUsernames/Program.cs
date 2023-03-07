using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            foreach (var item in users)
            {
                bool isValid = true;
                if (item.Length >= 3 && item.Length <= 16)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (!(item[i] == '_' || item[i] == '-' || char.IsLetterOrDigit(item[i])))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(item);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
    }
}
