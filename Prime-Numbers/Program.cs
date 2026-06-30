using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static (int Start, int End) GetValidRange(string startPrompt, string endPrompt)
        {
            while (true)
            {
                Console.Write(startPrompt);
                string startInput = Console.ReadLine();

                Console.Write(endPrompt);
                string endInput = Console.ReadLine();

                if (int.TryParse(startInput, out int start) &&
                    int.TryParse(endInput, out int end) &&
                    start > 1 &&
                    end > start)
                {
                    return (start, end);
                }

                Console.WriteLine("\nInvalid input. Please try again.\n");
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true; 

            if (number % 2 == 0 || number % 3 == 0) return false;

            int limit = (int)Math.Sqrt(number);

            for (int i = 5; i <= limit; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }
            return true;
        }
        public static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if(IsPrime(i)) primes.Add(i);
            }
            return primes;
        }
        public static void PrintPrimes(IEnumerable<int> primes)
        {
            Console.WriteLine("Prime numbers in the range:");
            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }
        }
        public static (int start , int end) AskUserForRange()
        {
            return GetValidRange("Enter the starting number of the range (greater than 1): ", "Enter the ending number of the range (greater than start): ");

        }
        static void Main(string[] args)
        {

             (int start,int end) = AskUserForRange();
            PrintPrimes(FindPrimesInRange(start, end));
        }
    }
}
