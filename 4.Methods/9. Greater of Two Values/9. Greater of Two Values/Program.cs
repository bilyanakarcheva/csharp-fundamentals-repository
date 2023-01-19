using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    Console.WriteLine(GetMaxInt());
                    break;
                case "char":
                    Console.WriteLine(GetMaxChar());
                    break;
                case "string":
                    Console.WriteLine(GetMaxString());
                    break;
                default:
                    break;
            }


        }

        static int GetMaxInt()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMaxChar()
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            if ((int)char1 > (int)char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }

        static string GetMaxString()
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            int compare = string1.CompareTo(string2);

            if (compare > 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
    }
}
