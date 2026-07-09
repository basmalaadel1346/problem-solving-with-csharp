using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShuffle
{
    internal class Program
    {
        private static readonly Random _random = new Random();
        public static void InvalidInputMessage()
        {
            Console.WriteLine("Invalid input, please try again.");
        }
        public static int ReadNumber(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                InvalidInputMessage();
            }
        }
        public static (int from, int to) ReadRange()
        {
            do
            {
                int from = 0; int to = 0;
                from = ReadNumber("Enter the start of the range: ");
                to = ReadNumber("Enter the end of the range: ");
                if(from < to)
                {
                    return (from, to);
                }
                else if (from > to) return (to, from);
                else
                {
                    InvalidInputMessage();
                }


            } while (true);
        }
        public static int[] GenerateArray(int from, int to)
        {
            int[] array = new int[to - from + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = from + i;
            }
            return array;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int GenerateRandomNumber(int from, int to) => _random.Next(from, to + 1);

        public static void ShuffleArray(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int randomIndex = GenerateRandomNumber(0, i);
                Swap(ref array[i], ref array[randomIndex]);
            }
        }
        public static void Run()
        {
             Console.WriteLine("Welcome to the Array Shuffle Program!");
            var (from, to) = ReadRange();
            int[] array = GenerateArray(from, to);
            Console.WriteLine("Original array: " + string.Join(", ", array));
            ShuffleArray(array);
            Console.WriteLine("Shuffled array: " + string.Join(", ", array)); 
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
