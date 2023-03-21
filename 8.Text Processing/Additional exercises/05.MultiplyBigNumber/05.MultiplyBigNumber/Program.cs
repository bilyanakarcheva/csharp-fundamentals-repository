using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int singleDigit = int.Parse(Console.ReadLine());
            int currentNum = 0;

            StringBuilder result = new StringBuilder();


            for (int i = 0; i < bigNumber.Length; i++)
            {
                currentNum = bigNumber[i] * singleDigit;

                if (currentNum >  9)
                {
                    currentNum /= 10;
                    currentNum %= 10;
                }
            }
        }
    }
}
