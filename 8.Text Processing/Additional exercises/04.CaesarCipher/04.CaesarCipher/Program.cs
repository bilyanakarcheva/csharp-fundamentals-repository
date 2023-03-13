using System;
using System.Linq;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {

                encryptedText.Append((char)(input[i] + 3));
            }

            Console.WriteLine(encryptedText);

        }
    }
}
