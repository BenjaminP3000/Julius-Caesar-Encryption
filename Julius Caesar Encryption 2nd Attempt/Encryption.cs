using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julius_Caesar_Encryption_2nd_Attempt
{
    internal class Encryption
    {
        public static void EncryptMessage()
        {
            Console.Write("Skriv meddelande för kryptering: ");
            string userMessage = Console.ReadLine().ToUpper();
            Console.Write("Ange krypteringsnyckel (siffra 1-26): ");
            int encryptionKey = Convert.ToInt32(Console.ReadLine());

            var intArray = new int[userMessage.Length];
            var encryptedString = String.Empty;
            var charArray = new char[userMessage.Length];

            for (int i = 0; i < userMessage.Length; i++)
            {
                intArray[i] = (int)userMessage[i];
                if (intArray[i] >= 65 && intArray[i] <= 90)
                {
                    intArray[i] = ((intArray[i] - 65 + encryptionKey) % 26) + 65;
                }
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                charArray[i] = (char)intArray[i];
            }   

            encryptedString = new string(charArray);

            Console.WriteLine(encryptedString);

            Console.ReadKey();
        }
    }
}
