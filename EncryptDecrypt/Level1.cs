using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    
    internal class Level1
    {
        static char[] BasicAlphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};
        
        static string KeyWord = "EVAN AND OLIVIA REED";
        static int key;


        static public string Encrypt(string message)
        {
            string cipher = "";
            int KeyWordIndex = 0;

            foreach (char c in message)
            {
                //Console.WriteLine(c);

                for (int i = 0; i < BasicAlphabet.Length; i++)
                {
                    if (KeyWord[KeyWordIndex] == BasicAlphabet[i])
                    {
                        key = i;
                        //Console.WriteLine("Key = " + key);
                        KeyWordIndex++;
                        if (KeyWordIndex >= KeyWord.Length)
                        {
                            KeyWordIndex = 0;
                        }
                        break;
                    }
                }
                for (int i = 0; i < BasicAlphabet.Length; i++)
                {
                    
                    if (c == BasicAlphabet[i])
                    {
                        int keycode = (i + key) % BasicAlphabet.Length;
                        //Console.Write(keycode);
                        //Console.WriteLine(BasicAlphabet[keycode]);
                        cipher += BasicAlphabet[keycode];
                    }
                }
            }

           return cipher;

        }

        static public string Decrypt(string cipher)
        {
            string message = "";
            int KeyWordIndex = 0;

            foreach (char c in cipher)
            {
                for (int i = 0; i < BasicAlphabet.Length; i++)
                {
                    if (KeyWord[KeyWordIndex] == BasicAlphabet[i])
                    {
                        key = i;
                        //Console.WriteLine("Key = " + key);
                        KeyWordIndex++;
                        if (KeyWordIndex >= KeyWord.Length)
                        {
                            KeyWordIndex = 0;
                        }
                        break;
                    }
                }
                for (int i = 0; i < BasicAlphabet.Length; i++)
                {

                    if (c == BasicAlphabet[i])
                    {
                       // Console.WriteLine(i + " ; " + key);
                        int keycode = (i + (BasicAlphabet.Length - key)) % BasicAlphabet.Length;
                       // Console.WriteLine(keycode);
                       // Console.WriteLine(BasicAlphabet[keycode]);
                        message += BasicAlphabet[keycode];
                    }
                }
            }

            return message;

        }
    }
}
