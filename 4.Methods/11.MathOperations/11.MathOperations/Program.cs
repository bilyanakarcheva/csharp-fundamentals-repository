using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Calculator(num1, operators, num2);
        }

        static void Calculator(int num1, char operators, int num2)
        {
            double result = 0;

            switch (operators)
            {
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                default:
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
