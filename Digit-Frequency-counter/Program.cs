using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitFrequency
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            PrintDigitFrequency(CalculateDigitFrequency(AskForNumber("Enter a number: ")));
        }
    }
}
