using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            ValidatePassword(text);

        }

        static void ValidatePassword(string text)
        {
            if (text.Length < 6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters" );
            }
          
            for (int i = 0; i < text.Length; i++)
            {
                int currentLetter = text[i];
                if (currentLetter > 47 && currentLetter < 58 || currentLetter > 64 && currentLetter < 91 || currentLetter > 96 && currentLetter < 123)
                {

                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
            }

            int countOfDigits = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int currentLetter = text[i];
                if ((currentLetter > 47 && currentLetter < 58))
                {

                }

                    Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
