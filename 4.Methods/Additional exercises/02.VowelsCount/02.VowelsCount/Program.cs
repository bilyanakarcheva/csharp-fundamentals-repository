using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsCount(input);

        }

        static void VowelsCount(string input) // a, o, i, e, u, y
        {

            int count = 0;
            foreach (var item in input)
	            {
                    if (item == 65 || item == 69 || item == 73 || item == 79 || item == 85 || item == 89 
                    || item == 97 || item == 101 || item == 105 || item == 111 || item == 117 || item == 121)
	                {
                    count++; 
	                }
	            }
            Console.WriteLine(count);
        }


    }
}
