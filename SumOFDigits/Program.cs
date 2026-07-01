using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
        public static void PrintSumOfDigits(int number)
        {
            int sum = SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of {number} is: {sum}");
        }
        static void Main(string[] args)
        {
            int number = GetNumber("Enter a number:");
            PrintSumOfDigits(number);
        }
    }
}
