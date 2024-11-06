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
                        Decrypt();
                        break;
                    case "3":
                        DecryptWithoutKey();
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

        public static void Encrypt()
        {
            Console.WriteLine("Enter message to encrypt:");
            string userMessage = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter encryption key (number 1 - 27): ");
            int encryptionKey = Convert.ToInt32(Console.ReadLine());

            int[] intArray = StringToInt(userMessage);

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = intArray[i] + encryptionKey;
            }

            char[] encryptedCharArray = Array.ConvertAll(intArray, x => (char)x);
            string encryptedString = new string(encryptedCharArray);
           
            Console.WriteLine($"Encrypted message: {encryptedString}");
        }

        public static void Decrypt()
        {
            Console.WriteLine("Enter message to decrypt:");
            string userMessage = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter encryption key (number 1 - 27): ");
            int encryptionKey = Convert.ToInt32(Console.ReadLine());

            int[] intArray = StringToInt(userMessage);

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = intArray[i] - encryptionKey;
            }

            char[] decryptedCharArray = Array.ConvertAll(intArray, x => (char)x);
            string decryptedString = new string(decryptedCharArray);
            
            Console.WriteLine($"Decrypted message: {decryptedString}");


        }

        public static void DecryptWithoutKey()
        {
            Console.WriteLine("Enter message to decrypt:");
            string userMessage = Console.ReadLine().ToUpper();

            int[] intArray = StringToInt(userMessage);


            for (int key = 1; key <= 27; key++)
            {
                int[] intArrayCopy = intArray;
                
                for (int j = 0; j < intArrayCopy.Length; j++)
                {
                    intArray[j] = intArray[j] - key;
                }
                char[] decryptedCharArray = Array.ConvertAll(intArray, x => (char)x);
                string decryptedString = new string(decryptedCharArray);
                
                Console.WriteLine($"Decrypted message: {decryptedString}");
            }     
        }
    }
}
