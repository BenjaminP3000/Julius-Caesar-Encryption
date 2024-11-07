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
            string userMessage = Console.ReadLine();
            Console.Write("Ange krypteringsnyckel (siffra 1-26): ");
            int encryptionKey = Convert.ToInt32(Console.ReadLine());

            var intArray = new int[userMessage.Length];

            for (int i = 0; i < userMessage.Length; i++)
            {
                intArray[i] = (int)Char.GetNumericValue(userMessage, i);
                if (intArray[i] >= 65 && intArray[i] >= 90)
                {
                    intArray[i] += encryptionKey;
                }
            }
        }
    }
}
