using System.Reflection.Metadata.Ecma335;

namespace Julius_Caesar_Encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {

            while (true)
            {
                Console.WriteLine("1. Encrypt message");
                Console.WriteLine("2. Decrypt message");
                Console.WriteLine("3. Decrypt without key");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Encrypt();
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        continue;
                }
            }

        }

        public static int[] StringToInt(string userString)
        {
            char[] charArray = userString.ToCharArray();
            int[] intArray = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                intArray[i] = (int)charArray[i];
            }
            return intArray;

        }

        public static void IntToString(int[] intArray)
        {
            string encryptedString = intArray.ToString();

            Console.WriteLine(encryptedString);
        }

        public static void Encrypt()
        {
            Console.WriteLine("Enter message to encrypt:");
            string userMessage = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter encryption key (number 1 - 27): ");
            int encryptionKey = Convert.ToInt32(Console.ReadLine());

            int[] intArray = StringToInt(userMessage);

            foreach (int i in intArray)
            {
                intArray[i] = intArray[i] + encryptionKey;
            }



        }

    }
}
