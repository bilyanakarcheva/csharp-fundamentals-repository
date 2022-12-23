using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleOnEachWagon = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                peopleOnEachWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleOnEachWagon[i];
            }

            Console.Write(String.Join(' ', peopleOnEachWagon));
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
