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
            while (number != 0)
            {
                int lastDigit = number % 10;
                reversed= reversed*10 + lastDigit;
                number /= 10;
            }
            return reversed;
        }
        static void Main(string[] args)
        {
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine($"Original Number: {number}");
            Console.WriteLine($"Reversed Number: {reversedNumber}");
            Console.ReadKey();
        }
    }
}
