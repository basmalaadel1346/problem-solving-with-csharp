using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Array_Algorithms
{
    internal class Program
    {
        private static readonly Random _random = new Random();
        public static void InvalidMessage() => Console.WriteLine("Invalid input, Please try again");

        public static int ReadNumber(string message)
        {
            while (true) 
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value)) { return value; }
                InvalidMessage();
            } 
        }
        public static int NumberOfElements()
        {
            while (true)
            {
                int number = ReadNumber("Please enter number of elements");
                if (number > 0) return number;
                InvalidMessage();
            }
            
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
        public static double CalculateAverage(int count, int sum)
        {
            return (double)sum / count;
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
        public static List<int> FindPrimes(int[] randomNumbers)
        {
            List<int> primes = new List<int>();
            foreach (int number in randomNumbers)
            {
                if (IsPrime(number))
                    primes.Add(number);
            }
            return primes;
        }
        public static void ShowArray(IReadOnlyCollection<int> array, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item,10}");
            }
            Console.WriteLine("\n");
            Console.WriteLine(new string('*', (array.Count)*10));
            Console.WriteLine();

        }
        public static int[] ZipTwoArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Arrays must have the same length");
            int length = array1.Length;
            int[] zippedArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                zippedArray[i]= array1[i] + array2[i];
            }
            
            return zippedArray;
        }
        public static int[] ReverseArray(int[] array)
        {
            int length = array.Length;
            int[] reversedArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                reversedArray[i] = array[length - 1 - i];
            }
            return reversedArray;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void ReverseArrayInPlace(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                Swap(ref array[i], ref array[length - 1 - i]);
            }
        }
        public static int FindIndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1; // Return -1 if the value is not found
        }
       public static void ShowSearchResult(int index)
        {
            if(index != -1)
                Console.WriteLine($"Value found at index {index}");
            else
                Console.WriteLine($"Value not found in the array"); 
          Console.WriteLine();
        }
        public static bool IsNumberInArray(int[] array, int value)
        {
            return FindIndexOf(array, value) != -1;
        }
        public static int[] FindDistinct(int[] array)
        {
            HashSet<int> distinctNumbers = new HashSet<int>();
            foreach (int number in array)
            {
                distinctNumbers.Add(number);
            }
            return distinctNumbers.ToArray();

        }
        static void Main(string[] args)
        {
            int numberOfElements = NumberOfElements();
            var (min, max) = ReadRange();
            int[] randomNumbers = GenerateRandomNumbers(numberOfElements, min, max);
            int[] randomNumbers2 = GenerateRandomNumbers(numberOfElements, min, max);
            ShowArray(randomNumbers, "Random Numbers:");
            var (minRandom, maxRandom) = FindMinAndMax(randomNumbers);
            ShowOperation(minRandom, "Min");
            ShowOperation(maxRandom, "Max");
            int sum = CalculateSum(randomNumbers);
            ShowOperation(sum, "Sum");
            ShowOperation(CalculateAverage(randomNumbers.Length, sum), "Average");
            ShowArray(CopyArray(randomNumbers), "Copy of Random Numbers:");
            ShowArray(FindPrimes(randomNumbers), "Prime Numbers:");
            ShowArray(randomNumbers2, "Random Numbers 2:");
            ShowArray(ZipTwoArrays(randomNumbers, randomNumbers2), "Zipped Array (Sum of Two Arrays):");
            ShowArray(ReverseArray(randomNumbers), "Reversed Array:");
            int valueToFind = ReadNumber("please enter a number to find its index: ");
           int index =  FindIndexOf(randomNumbers, valueToFind);
            ShowSearchResult(index);
            ReverseArrayInPlace(randomNumbers);
            ShowArray(randomNumbers, "Reversed Array In Place:");
            ShowArray(FindDistinct(randomNumbers), "Distinct Numbers:");
        }
    }
}
