using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();



            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    numbers.Append(input[i]);
                }
                else if (char.IsLetter(currentChar))
                {
                    letters.Append(input[i]);
                }
                else
                {
                    symbols.Append(input[i]);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
