using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julius_Caesar_Encryption_2nd_Attempt
{
    internal class Decryption
    {
        public static void DecryptMessage()
        {
            Console.Write("Skriv meddelande för dekryptering: ");
            string userMessage = Console.ReadLine();
            Console.Write("Ange krypteringsnyckel (siffra 1-26): ");
            int encryptionKey = Convert.ToInt32(Console.ReadLine());

            var intArray = new int[userMessage.Length];
            var decryptedString = String.Empty;
            var charArray = new char[userMessage.Length];

            for (int i = 0; i < userMessage.Length; i++)
            {
                intArray[i] = (int)userMessage[i];
                if (intArray[i] >= 65 && intArray[i] <= 90)
                {
                    intArray[i] = ((intArray[i] - 65 - encryptionKey + 26) % 26) + 65;
                }
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                charArray[i] = (char)intArray[i];
            }

            decryptedString = new string(charArray);

            Console.WriteLine(decryptedString);

            Console.ReadKey();

        }

        public static void DecryptMessageWithoutKey()
        {
            Console.Write("Skriv meddelande för dekryptering: ");
            string userMessage = Console.ReadLine();

            var intArray = new int[userMessage.Length];
            var intArray2 = new int[userMessage.Length];
            var decryptedString = String.Empty;
            var charArray = new char[userMessage.Length];

            for (int i = 0; i < userMessage.Length; i++)
            {
                intArray[i] = (int)userMessage[i];
                intArray2[i] = (int)userMessage[i];
                if (intArray[i] >= 65 && intArray[i] <= 90)
                {
                    intArray[i] = ((intArray[i] - 65 - i + 26) % 26) + 65;
                }
                
                for (int j = 0; j < intArray2.Length; j++)
                {
                    charArray[j] = (char)intArray2[j];
                }
                
                decryptedString = new string(charArray);
                Console.WriteLine(decryptedString);

            }

            Console.ReadKey();

        }
    }
}
