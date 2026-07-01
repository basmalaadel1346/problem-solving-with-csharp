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
        static void Main(string[] args)
        {
            PrintInvertedPattern(GetNumber("Enter a number: "));
        }
    }
}
