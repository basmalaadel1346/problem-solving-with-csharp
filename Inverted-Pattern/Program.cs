using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    internal class Program
    {
        public static int GetNumber(string prompt)
        {
            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number > 0 && number <= 26)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 26.");
                }


            } while (true);
        }
        public static void PrintInvertedPattern(int number)
        {
            for (int i = number; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void PrintNumberPattern(int number)
        {
            for(int i = 1;  i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
        }
        public static void PrintInvertedLetterPattern(int number)
        {
            for (char letter = (char)('A' + number - 1); letter >= 'A'; letter--)
            {
                for(int j=1; j<=letter - 'A' + 1; j++)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }
        public static void PrintLetterPattern(int number)
        {
            for (char letter = 'A'; letter < 'A' + number; letter++)
            {
                for (int j = 1; j <= letter - 'A' + 1; j++)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int number = GetNumber("Enter a number: ");
            Console.WriteLine($"{"Inverted Pattern",70}");
            PrintInvertedPattern(number);
            Console.WriteLine();
            Console.WriteLine($"{"Number Pattern",70}");
            PrintNumberPattern(number);
            Console.WriteLine();
            Console.WriteLine($"{"Inverted Letter Pattern",70}");
            PrintInvertedLetterPattern(number);
            Console.WriteLine();
            Console.WriteLine($"{"Letter Pattern",70}");
            PrintLetterPattern(number);
        }
    }
}
