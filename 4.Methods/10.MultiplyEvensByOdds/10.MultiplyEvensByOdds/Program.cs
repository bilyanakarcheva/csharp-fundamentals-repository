using System;
using System.Diagnostics.Tracing;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            Console.WriteLine(GetMultipleOfEvenAndOdds(n)); 
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sumEven = 0;
            string number = n.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                int currentNum = int.Parse(number[i].ToString()); // turn char into string and then parse it into int
                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }

            }

            return sumEven;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sumOdds = 0;
            string number = n.ToString();


            for (int i = 0; i < number.Length; i++)
            {
                int currentDigt = int.Parse(number[i].ToString());

                if (currentDigt % 2 != 0)
                {
                    sumOdds += currentDigt;
                }
            }

            return sumOdds;
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }
    }
}
