using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordBruteForce
{
    internal class Program
    {
        public static IEnumerable<string> GenerateAllPasswords()
        {
            for (char first = 'A'; first <= 'Z'; first++)
            {
                for (char second = 'A'; second <= 'Z'; second++)
                {
                    for (char third = 'A'; third <= 'Z'; third++)
                    {
                        yield return $"{first}{second}{third}";
                    }
                }
            }
        }

        public static string AskUserForPassword(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);

                string password = Console.ReadLine()?.Trim().ToUpper();

                if (password != null &&
                    password.Length == 3 &&
                    password.All(char.IsLetter))
                {
                    return password;
                }

                Console.WriteLine("Invalid password. Please enter exactly 3 English letters (A-Z).\n");
            }
        }

        public static int GuessPassword(string targetPassword)
        {
            int attempts = 0;

            foreach (string guess in GenerateAllPasswords())
            {
                attempts++;

                if (targetPassword == guess)
                {
                    return attempts;
                }
            }

            return attempts;
        }

        public static void RunPasswordCracker()
        {
            string password = AskUserForPassword("Enter a password (exactly 3 English letters): ");

            int attempts = GuessPassword(password);

            Console.WriteLine("\nPassword found successfully!");
            Console.WriteLine($"Password : {password}");
            Console.WriteLine($"Attempts : {attempts}");
        }

        static void Main(string[] args)
        {
            RunPasswordCracker();
        }
    }
}