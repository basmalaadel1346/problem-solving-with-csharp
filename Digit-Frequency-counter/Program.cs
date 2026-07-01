using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitFrequency
{
    internal class Program
    {
        public enum MenuChoice
        {
            CalculateDigitFrequency = 1,
            ShowDigits = 2,
            Exit = 3
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
        static public void PrintDigitFrequency(int[] digitFrequency)
        {
            for (int i = 0; i < digitFrequency.Length; i++)
            {
                if (digitFrequency[i] > 0)
                {
                    Console.WriteLine($"Digit {i} appears {digitFrequency[i]} times.");
                }
            }
        }
        public static List<int> GetUniqueDigits(IEnumerable<int> digitFrequency)
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
        public static void ShowDigits(IEnumerable<int> digits) => Console.WriteLine("Digits in the number: " + string.Join(", ", digits));
        
        public static MenuChoice GetMenuChoice()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Digit Frequency");
            Console.WriteLine("2. Show Digits");
            Console.WriteLine("3. Exit");
            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out MenuChoice choice)
                    && Enum.IsDefined(typeof(MenuChoice), choice))
                {
                    return choice;
                }

                Console.WriteLine("Invalid choice.");
            }
        }
        public static void HandleMenuChoice(MenuChoice choice)
        {
            int number = AskForNumber("Enter a number: ");
            int[] digitFrequency = CalculateDigitFrequency(number);
            
                switch (choice)
                {
                    case MenuChoice.CalculateDigitFrequency:
                        PrintDigitFrequency(digitFrequency);
                        break;
                    case MenuChoice.ShowDigits:
                        ShowDigits(GetUniqueDigits(digitFrequency));
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
                    break;
                }
                HandleMenuChoice(choice);
            }
            
        }
    }
}
