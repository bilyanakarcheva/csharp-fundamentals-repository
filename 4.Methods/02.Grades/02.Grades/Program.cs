using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);

        }

        static void PrintGrade(double input)
        {
            if (input >= 2.00 && input <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (input >= 3.00 && input <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (input >= 3.50 && input <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (input >= 4.50 && input <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (input >= 5.50 && input <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
