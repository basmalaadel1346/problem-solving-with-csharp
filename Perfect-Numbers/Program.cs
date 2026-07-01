using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPerfectNumber
{
    internal class Program
    {
        public enum EnMenuOptions
        {
            CheckIfNumberIsPerfect = 1,
            FindAllPerfectNumbersInRange = 2,
            Exit = 3
        }
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
        public static (int, int) AskUserForRange()
        {
            while (true)
            {
                int start = AskUserForNumber("Enter the start of the range (positive integer): ");
                int end = AskUserForNumber("Enter the end of the range (positive integer): ");
                if (start <= end)
                {
                    return (start, end);
                }
                else
                {
                    Console.WriteLine("Invalid range. The start of the range must be less than or equal to the end.");
                }
            }
        }
        public static List<int> FindAllPerfectNumbersInRange(int start, int end)
        {
            List<int> perfectNumbers = new List<int>();
            for(int i =start; i <= end; i++) 
            {
                if(IsPerfectNumber(i))
                {
                    perfectNumbers.Add(i);
                }
            }
            return perfectNumbers;
        }
        public static void PrintPerfectNumbersInRange(IEnumerable<int> perfectNumbers)
            {
            Console.WriteLine("Perfect numbers in the specified range:");
            foreach (var perfectNumber in perfectNumbers)
            {
                Console.WriteLine(perfectNumber);
            }
        }
        public static EnMenuOptions ShowMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check if a number is perfect");
            Console.WriteLine("2. Find all perfect numbers in a range");
            Console.WriteLine("3. Exit");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice)
                    && Enum.IsDefined(typeof(EnMenuOptions), choice))
                {
                    return (EnMenuOptions)choice;
                }

                Console.WriteLine("Invalid choice.");
            }
        }
        static void HandleMenuChoice(EnMenuOptions choice)
        {
            switch (choice)
            {
                case EnMenuOptions.CheckIfNumberIsPerfect:
                    PrintPerfectNumberCheck(AskUserForNumber("Enter a positive integer: "));
                    break;
                case EnMenuOptions.FindAllPerfectNumbersInRange:
                    var (start, end) = AskUserForRange();
                    List<int> perfectNumbers = FindAllPerfectNumbersInRange(start, end);
                    PrintPerfectNumbersInRange(perfectNumbers);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

       
        static void Main(string[] args)
        {
            while (true)
            {
                var option = ShowMenu();

                if (option == EnMenuOptions.Exit)
                    break;

                HandleMenuChoice(option);
            }
        }
    }
}
