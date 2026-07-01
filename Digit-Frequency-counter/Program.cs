using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitFrequency
{
    internal class Program
    {
        public enum MenuChoice
        {
            CalculateDigitFrequency = 1,
            ShowDigits = 2,
            CheckPalindrome = 3,
            Exit = 4
        }

        public static int AskForNumber(string prompt)
        {
            Console.WriteLine(prompt);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return number;
        }

        public static int[] CalculateDigitFrequency(int number)
        {
            number = Math.Abs(number);
            int[] digitFrequency = new int[10];

            do
            {
                digitFrequency[number % 10]++;
                number /= 10;
            } while (number != 0);

            return digitFrequency;
        }

        public static void PrintDigitFrequency(int[] digitFrequency)
        {
            for (int i = 0; i < digitFrequency.Length; i++)
            {
                if (digitFrequency[i] > 0)
                {
                    Console.WriteLine($"Digit {i} appears {digitFrequency[i]} times.");
                }
            }
        }

        public static List<int> GetAllDigits(int number)
        {
            List<int> digits = new List<int>();
            number = Math.Abs(number);

            do
            {
                digits.Add(number % 10);
                number /= 10;
            } while (number != 0);

            return digits;
        }

        public static List<int> GetUniqueDigits(int[] digitFrequency)
        {
            List<int> digits = new List<int>();
            int i = 0;
            foreach (var freq in digitFrequency)
            {
                if (freq > 0) digits.Add(i);
                i++;
            }
            return digits;
        }

        public static void ShowDigits(IEnumerable<int> digits) =>
            Console.WriteLine("Digits in the number: " + string.Join(", ", digits));

        public static bool IsNumberPalindrome(IReadOnlyList<int> digits)
        {
            if (digits == null) return false;

            for (int i = 0; i < digits.Count / 2; i++)
            {
                if (digits[i] != digits[digits.Count - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void ShowPalindromeResult(IReadOnlyList<int> digits)
        {
            if (IsNumberPalindrome(digits))
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }

        public static MenuChoice GetMenuChoice()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Digit Frequency");
            Console.WriteLine("2. Show Digits");
            Console.WriteLine("3. Check Palindrome");
            Console.WriteLine("4. Exit");

            MenuChoice choice;
            while (!Enum.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(MenuChoice), choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

            return choice;
        }

        public static void HandleMenuChoice(MenuChoice choice)
        {
            int number = AskForNumber("Enter a number: ");

            switch (choice)
            {
                case MenuChoice.CalculateDigitFrequency:
                    int[] digitFrequency = CalculateDigitFrequency(number);
                    PrintDigitFrequency(digitFrequency);
                    break;

                case MenuChoice.ShowDigits:
                    int[] freqForUnique = CalculateDigitFrequency(number);
                    ShowDigits(GetUniqueDigits(freqForUnique));
                    break;

                case MenuChoice.CheckPalindrome:
                    List<int> allDigits = GetAllDigits(number);
                    ShowPalindromeResult(allDigits);
                    break;
            }
            Console.WriteLine(new string('-', 30));
        }

        static void Main(string[] args)
        {
            while (true)
            {
                MenuChoice choice = GetMenuChoice();

                if (choice == MenuChoice.Exit)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                HandleMenuChoice(choice);
            }
        }
    }
}