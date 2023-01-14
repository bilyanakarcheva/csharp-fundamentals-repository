using System;

namespace _6.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
          
            Console.WriteLine(CalculateRectangleArea(width, height));
        }

        static int CalculateRectangleArea(int width, int height)
        {
            return width * height;
        }


    }
}
