using System;
using System.Transactions;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string forRemoval = Console.ReadLine();
            string longerString = Console.ReadLine();

            int currentIndex = longerString.IndexOf(forRemoval);

            while (currentIndex >= 0)
            {              
                longerString = longerString.Remove(currentIndex, forRemoval.Length);
                currentIndex = longerString.IndexOf(forRemoval);
            }

            Console.WriteLine(longerString);
        }
    }
}
