using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char charStart = char.Parse(Console.ReadLine());
            char charEnd = char.Parse(Console.ReadLine());
            CharactersInBetween2Chars(charStart, charEnd);
        }

        static void CharactersInBetween2Chars(char charStart, char charEnd)
        {
            if (charStart > charEnd)
            {
                for (int i = charEnd + 1; i < charStart; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = charStart + 1; i < charEnd; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
