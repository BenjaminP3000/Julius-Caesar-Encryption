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

            var charArray = new char[userMessage.Length];

            for (int i = 0; i < userMessage.Length; i++)
            {
                charArray[i] = userMessage[i];
            }


        }
    }
}
