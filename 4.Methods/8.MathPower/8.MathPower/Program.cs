using System;
using System.Net;
using System.Reflection;

namespace _8.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine()); // number could be floating-point
            int power = int.Parse(Console.ReadLine()); // power could only be integer

            Console.WriteLine(PowOfANumber(num, power));
        }

        static double PowOfANumber(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
