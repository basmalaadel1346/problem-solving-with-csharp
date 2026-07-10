using System;
using System.Text;

namespace prob21
{
    internal class Program
    {
        private static readonly Random _random = new Random();

        public enum KeyType
        {
            Numeric=1,
            AlphaSmall,
            AlphaCapital
        }

        public static (char from, char to) GetBounds(KeyType keyType)
        {
            switch (keyType)
            {
                case KeyType.Numeric:
                    return ('0', '9');
                case KeyType.AlphaSmall:
                    return ('a', 'z');
                case KeyType.AlphaCapital:
                    return ('A', 'Z');
                default:
                    throw new ArgumentOutOfRangeException(nameof(keyType));
            }
        }

        public static string MakeWord(int length, KeyType keyType)
        {
            var (from, to) = GetBounds(keyType);
            StringBuilder word = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                word.Append((char)_random.Next(from, to + 1));
            }
            return word.ToString();
        }

        public static string MakeKey(int partsCount, int partLength, KeyType keyType)
        {
            StringBuilder key = new StringBuilder();
            for (int i = 0; i < partsCount; i++)
{
    if (i > 0)
        key.Append('-');

    key.Append(MakeWord(partLength, keyType));
}


            return key.ToString();
        }
        // way with StringBuilder
        public static string MakeKeys(int count, int partsCount = 4, int partLength = 4, KeyType keyType = KeyType.Numeric)
        {
            StringBuilder keys = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                keys.Append(MakeKey(partsCount, partLength, keyType));
                keys.AppendLine();
            }
            return keys.ToString();
        }
        // Alternative implementation using array for comparison.
        /*public static string[] MakeKeys(int count, int partsCount = 4, int partLength = 4, KeyType keyType = KeyType.Numeric)
        {
            string[] keys = new string[count];
            for (int i = 0; i < count; i++)
            {
                keys[i] = MakeKey(partsCount, partLength, keyType);
            }
            return keys;
        }*/
        // Alternative implementation using string.Join for comparison.
        /*
        public static string MakeKeysString(int count, int partsCount = 4, int partLength = 4, KeyType keyType = KeyType.Numeric)
        {
            string[] keys = new string[count];
            for (int i = 0; i < count; i++)
            {
                keys[i] = MakeKey(partsCount, partLength, keyType);
            }
            return string.Join(Environment.NewLine, keys);
        }*/
        public static KeyType AskForKeyType()
        {
            Console.WriteLine("Enter the key type (numeric, alphaSmall, alphaCapital):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input?.Trim(), true, out KeyType keyType))
            {
                return keyType;
            }
            else
            {
                Console.WriteLine("Invalid key type. Defaulting to numeric.");
                return KeyType.Numeric;
            }
        }

        public static int AskForNumber(string message, string errorMessage)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }

                Console.WriteLine(errorMessage);
            }
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Key Generator!");
            Console.WriteLine("You can generate keys with different types and formats.");
            Console.WriteLine("Please follow the prompts to customize your keys.\n");
        }

        public static void ShowGeneratedKeys(int numOfKeys, KeyType type)
        {
            Console.WriteLine("\n--- Generated Keys ---");
            Console.WriteLine(MakeKeys(numOfKeys, partsCount: 4, partLength: 4, type));
        }

        static void Main(string[] args)
        {
            WelcomeMessage();

            int numOfKeys = AskForNumber("Enter number of keys", "Invalid number.");
            KeyType type = AskForKeyType();

            ShowGeneratedKeys(numOfKeys, type);

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}