using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Array_With_Random_Numbers
{
    internal class Program
    {
        private static readonly Random _random = new Random();
        public static void InvalidMessage() => Console.WriteLine("Invalid input, Please try again");

        public static int ReadNumber(string message)
        {
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value)) { return value; }
                InvalidMessage();
            } while (true);
        }
        public static int NumberOfElements()
        {
            do
            {
                int number = 0;
                number = ReadNumber("Please enter number of elements");
                if (number > 0) return number;
                InvalidMessage();
            }
            while (true);
        }
        public static (int min, int max) ReadRange()

        {

            do
            {
                int min = ReadNumber("Please enter minimum value for range");
                int max = ReadNumber("Please enter max value for range");
                if (min < max) return (min, max);
                if (max < min) return (max, min);
                InvalidMessage();
            } while (true);
        } 

        public static int[] GenerateRandomNumbers(int numberOfElements, int min, int max)
        {
            int[] randomNumbers = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                randomNumbers[i] = _random.Next(min, max+1);
            }
            return randomNumbers;
        }
        public static (int min, int max) FindMinAndMax(int[] randomNumbers)
        {
            int min = randomNumbers[0];
            int max = randomNumbers[0];
            for (int i = 1; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > max)
                    max = randomNumbers[i];

                if (randomNumbers[i] < min)
                    min = randomNumbers[i];
            }
            return (min, max);
        }
        public static void ShowMinAndMax(int min, int max)
        {
            Console.WriteLine($"Min : {min} and Max : {max}");
        }
        public static int CalculateSum(int[] randomNumbers)
        {
            int sum = 0;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                sum += randomNumbers[i];
            }
            return sum;
        }
        public static void ShowOperation<T>(T operation, string operationName)
        {
            Console.WriteLine($"{operationName} : {operation}");
        }
        public static double CalculateAverage(int[] randomNumbers, int sum)
        {
            return (double)sum / randomNumbers.Length;
        }
        public static int[] CopyArray(int[] randomNumbers)
        {
            int[] copy = new int[randomNumbers.Length];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                copy[i] = randomNumbers[i];
            }
            return copy;
        }
        
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }
        public static int[] FindPrimesCopy(int[] randomNumbers)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (IsPrime(randomNumbers[i]))
                {
                    primes.Add(randomNumbers[i]);
                }
            }
            return primes.ToArray();
        }
        public static void ShowArray(int[] array, string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],30}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int numberOfElements = NumberOfElements();
            var (min, max) = ReadRange();
            int[] randomNumbers = GenerateRandomNumbers(numberOfElements, min, max);
            ShowArray(randomNumbers, "Random Numbers:");
            var (minRandom, maxRandom) = FindMinAndMax(randomNumbers);
            ShowMinAndMax(minRandom, maxRandom);
            int sum = CalculateSum(randomNumbers);
            ShowOperation(sum, "Sum");
            ShowOperation(CalculateAverage(randomNumbers, sum), "Average");
            ShowArray(CopyArray(randomNumbers), "Copy of Random Numbers:");
            ShowArray(FindPrimesCopy(randomNumbers), "Prime Numbers:");
        }
    }
}
