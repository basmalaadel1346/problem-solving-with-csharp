using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPerfectNumber
{
    internal class Program
    {
        public static int AskUserForNumber(string prompt)
        {
            int number;
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
        }
        public static bool IsDivisor(int number, int potentialDivisor)
        {
            return number % potentialDivisor == 0;
        }
        public static List<int> FindAllDivisors(int number)
        {
            List<int> divisors = new List<int>();
            int limit = (int)Math.Sqrt(number);
            int divisorPart2;
            for (int i = 1; i <= limit; i++)
            {
                if (IsDivisor(number, i))
                {
                    divisors.Add(i);
                    divisorPart2 = number / i;
                    if (divisorPart2 != i && divisorPart2 != number)
                    {
                        divisors.Add(divisorPart2);
                    }
                }
                
                    
            }
            return divisors;
        }
        public static int SumOfDivisors(IEnumerable<int> divisors) => divisors.Sum();
        public static bool IsPerfectNumber(int number)
        {

            List<int> divisors = FindAllDivisors(number);
            int sum = SumOfDivisors(divisors);

            return sum == number;
        }
        public static void PrintPerfectNumberCheck(int number)
        {
            Console.WriteLine($"Is {number} a Perfect number? : {IsPerfectNumber(number)}");
        }
        
        static void Main(string[] args)
        {
            PrintPerfectNumberCheck(AskUserForNumber("Enter a positive integer: "));
        }
    }
}
