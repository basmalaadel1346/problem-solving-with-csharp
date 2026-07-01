using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertpattern
{
    internal class Program
    {
        public static int GetNumber(string prompt)
        {
            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
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
        static void Main(string[] args)
        {
            int number = GetNumber("Enter a number: ");
            Console.WriteLine($"{"Inverted Pattern",70}");
            PrintInvertedPattern(number);
            Console.WriteLine($"{"Number Pattern",70}");

            PrintNumberPattern(number);
        }
    }
}
