using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrequencyInArray
{
    internal class Program
    {
        public static int ReadNumber(string message)
        {
            do
            {
                Console.WriteLine(message);
                string input= Console.ReadLine();
                if(int.TryParse(input, out int value) && value>0) { return value; }
                Console.WriteLine("Invalid message, Please try again");

            } while(true);
        }
        public static int NumberOfElements() => ReadNumber("Please enter number of elements");
        public static int[] StoreElements(int numberOfElements)
        {
            int[] elements = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                elements[i] = ReadNumber($"Please enter number {i+1}");
            }
            return elements;
        }
        public static int NumberToCheck() => ReadNumber("Please enter number you want to check");
        public static int CalculateFrequency(int[] elements, int number)
        {
            int frequency = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == number)
                    {
                        frequency++;
                    }
            }
            return frequency;
        }
        public static void ShowFrequencyOfNumber(int number, int frequency)
        {
            Console.WriteLine($"the number {number} his frequency {frequency}");
        }


        static void Main(string[] args)
        {
            int[] elements = StoreElements(NumberOfElements());
            int numberToCheck = NumberToCheck();
            ShowFrequencyOfNumber(numberToCheck, CalculateFrequency(elements, numberToCheck));
        }
    }
}
