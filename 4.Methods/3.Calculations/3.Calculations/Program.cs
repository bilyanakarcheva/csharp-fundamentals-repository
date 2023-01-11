using System;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string mathAction = Console.ReadLine();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (mathAction)
            {
                case "add":
                    AdditioOfNumbers(num1, num2);
                    break;
                case "multiply":
                    MiltiplicationOfNumbers(num1, num2);
                    break;
                case "subtract":
                    SubstractionOfNumbers(num1, num2);
                    break;
                case "divide":
                    DivisionOfNumbers(num1, num2);
                    break;
                default:
                    break;
            }
        }

        static void AdditioOfNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void MiltiplicationOfNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        static void SubstractionOfNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        static void DivisionOfNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
