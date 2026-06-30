using System;

namespace Multiplication_Table
{
    internal class Program
    {
        private const int TableSize = 10;

        public static void PrintTableHeader()
        {
            Console.WriteLine($"{"Multiplication Table",(TableSize + 1) * 5}\n");

            Console.Write($"{"",4}");

            for (int i = 1; i <= TableSize; i++)
            {
                Console.Write($"{i,10}");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', (TableSize + 1) * 10));
        }

        public static void PrintTableBody()
        {
            PrintTableHeader();

            for (int i = 1; i <= TableSize; i++)
            {
                Console.Write($"{i,4}");
                Console.Write("|");

                for (int j = 1; j <= TableSize; j++)
                {
                    Console.Write($"{i * j,10}");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintTableBody();
            Console.ReadLine();
        }
    }
}