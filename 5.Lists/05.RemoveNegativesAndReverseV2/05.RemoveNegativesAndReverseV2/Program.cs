List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] < 0)
    {
        numbers.RemoveAt(i);
        i--;
    }

}

if (numbers.Count == 0)// Check
{
    Console.WriteLine("empty");
}
else
{
    numbers.Reverse();
    Console.WriteLine(String.Join(" ", numbers));
}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _05.RemoveNegativesAndReverse
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = Console.ReadLine()
//                .Split()
//                .Select(int.Parse)
//                .ToList();

//            for (int i = 0; i < numbers.Count; i++)
//            {
//                if (numbers[i] < 0)
//                {
//                    numbers.RemoveAt(i);
//                    i--;
//                }

//            }

//            if (numbers.Count == 0)// Check
//            {
//                Console.WriteLine("empty");
//            }
//            else
//            {
//                numbers.Reverse();
//                Console.WriteLine(String.Join(" ", numbers));
//            }
//        }

//    }
//}
