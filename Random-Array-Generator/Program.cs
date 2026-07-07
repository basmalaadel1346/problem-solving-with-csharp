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
        public static void ShowRandomNumbers(int[] randomNumber)
        {
            for (int i = 0; i < randomNumber.Length; i++)
            {
                Console.WriteLine(randomNumber[i]);
            }
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
        static void Main(string[] args)
        {
            int numberOfElements = NumberOfElements();
            var (min, max) = ReadRange();
            int[] randomNumbers = GenerateRandomNumbers(numberOfElements, min, max);
            ShowRandomNumbers(randomNumbers);
            var (minRandom, maxRandom) = FindMinAndMax(randomNumbers);
            ShowMinAndMax(minRandom, maxRandom);
        }
    }
}
