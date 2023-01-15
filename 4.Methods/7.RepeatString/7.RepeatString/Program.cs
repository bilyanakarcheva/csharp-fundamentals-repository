using System;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringNTimes(str1, n));
        }

        static string RepeatStringNTimes(string str1, int n)
        {
            string newString = String.Empty;
            
            for (int i = 0; i < n; i++)
            {
                newString += str1;
            }

            return newString;
        }
    }
}
