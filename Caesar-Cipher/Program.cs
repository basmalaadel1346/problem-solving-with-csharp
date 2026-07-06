using System;

namespace Prob18
{
    internal class Program
    {
        public static string ReadText(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine(); 
        }

        private static string ShiftText(string text, short shiftValue)
        {
            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = (char)(characters[i] + shiftValue);
            }
            return new string(characters);
        }

        public static string EncryptText(string text, short encryptKey)
        {
            return ShiftText(text, encryptKey);
        }

        public static string DecryptText(string text, short encryptKey)
        {
            return ShiftText(text, (short)-encryptKey);
        }

        static void Main(string[] args)
        {
            string text = ReadText("Enter the text to encrypt:");
            const short encryptKey = 3;

            string encryptedText = EncryptText(text, encryptKey);
            Console.WriteLine("Encrypted text: " + encryptedText);

            string decryptedText = DecryptText(encryptedText, encryptKey);
            Console.WriteLine("Decrypted text: " + decryptedText);
        }
    }
}