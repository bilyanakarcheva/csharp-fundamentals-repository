using System;

namespace _04.ReverseArrayОfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // -1 hi ho w

            string[] array = input.Split(); 

            for (int i = 0; i < array.Length / 2; i++) // dividing by 2 because we exchange one element for another therefore we have to do half as much iterations of the loop
            {
                string oldElement = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = oldElement;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
