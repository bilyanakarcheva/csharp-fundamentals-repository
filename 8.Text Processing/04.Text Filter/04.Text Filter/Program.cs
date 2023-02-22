using System;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var banWord in banList)
            {

                string replacementWord = new string('*', banWord.Length);
                text = text.Replace(banWord, replacementWord); // With Replace the original string has to be overriten by the new string.

            }

            Console.WriteLine(text);
        }
    }
}
