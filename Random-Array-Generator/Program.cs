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
                if (int.TryParse(input, out int value) && value >= 0) { return value; }
                InvalidMessage();
            } while (true);
        }
        public static int NumberOfElements() => ReadNumber("Please enter number of elements");
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
        static void Main(string[] args)
        {
            int numberOfElements = NumberOfElements();
            var (min, max) = ReadRange();
            ShowRandomNumbers(GenerateRandomNumbers(numberOfElements, min, max));
        }
    }
}
