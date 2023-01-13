using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(order, quantity);
        }

        static void CalculateOrder(string order, int quantity)
        {
            switch (order)
            {
                case "coffee":
                    Console.WriteLine($"{1.50 * quantity:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{1.00 * quantity:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{1.40 * quantity:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{2.00 * quantity:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
