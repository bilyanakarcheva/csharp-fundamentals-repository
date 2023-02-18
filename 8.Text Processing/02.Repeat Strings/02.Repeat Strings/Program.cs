using System;

namespace _02.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(); // work

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {

                for (int j = 0; j < arrayOfStrings[i].Length; j++)
                {
                    Console.Write(arrayOfStrings[i]);
                }
            }
        }
    }
}
