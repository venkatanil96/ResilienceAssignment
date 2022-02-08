using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Encryption
    {
        class Encrypter
        {
            public static string Encrypted(string txt)
            {
                int letterInt = 0;
                char letter = ' ';
                string textEncripted = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    letterInt = (int)txt[i] + 1;
                    letter = (char)letterInt;
                    textEncripted += letter.ToString();
                }
                return textEncripted;
            }

            public static string Decrypted(string txt)
            {
                int letterInt = 0;
                char letter = ' ';
                string textDecripted = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    letterInt = (int)txt[i] - 1;
                    letter = (char)letterInt;
                    textDecripted += letter.ToString();
                }
                return textDecripted;
            }
        }
        class TextEncrypted
        {
            static void Main()
            {
                bool debug = true;

                string newText = Encrypter.Encrypted("Anil");
                Console.WriteLine("Text encripted: {0}", newText);
                string TextDescripted = Encrypter.Decrypted(newText);
                Console.WriteLine("Text Decripted: {0}", TextDescripted);

                if (debug)
                    Console.ReadLine();
            }
        }
    }
}
