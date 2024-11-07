using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julius_Caesar_Encryption_2nd_Attempt
{
    internal class Menu
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Kryptera meddelande");
                Console.WriteLine("2. Dekryptera meddelande");
                Console.WriteLine("3. Dekryptera meddelande utan nyckel");
                Console.WriteLine("4. Avsluta");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Encryption.EncryptMessage();
                        break;

                    case "2":
                        Decryption.DecryptMessage();
                        break;

                    case "3":
                        Decryption.DecryptMessageWithoutKey();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Du är en imbecill");
                        continue;

                }
            }
        }
    }
}
