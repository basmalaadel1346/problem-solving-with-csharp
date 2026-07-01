using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumber
{
    internal class Program
    {
        const int number = 12345;
        public static int ReverseNumber(int number)
        {
            int reversed = 0;
            do
            {
                int lastDigit = number % 10;
                reversed = reversed * 10 + lastDigit;
                number /= 10;
            } while (number != 0);
            return reversed;
        }
        public static bool IsPalindrome(int originalNumber, int reversedNumber) => originalNumber == reversedNumber;
        public static void PrintResult(int number, int reversedNumber)
        {
            Console.WriteLine($"Original Number: {number}");
            Console.WriteLine($"Reversed Number: {reversedNumber}");
            if (IsPalindrome(number, reversedNumber))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
        static void Main(string[] args)
        {
            PrintResult(number, ReverseNumber(number));
            Console.ReadKey();
        }
    }
}
