﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

//CODE FROM https://stackoverflow.com/questions/273452/using-aes-encryption-in-c-sharp

namespace ConnectionInfo
{
    class Encryption
    {
        private const string errorText = "There was a problem with your key.\t\t\t";

        public static byte[] key;

        public static String Encrypt(String text)
        {
            String encryptedText = "";

            try
            {
                // Create a new instance of the RijndaelManaged 
                // class.  This generates a new key and initialization  
                // vector (IV). 
                using (RijndaelManaged myRijndael = new RijndaelManaged())
                {
                    myRijndael.GenerateIV();
                    // Encrypt the string to an array of bytes. 
                    byte[] encrypted = EncryptStringToBytes(text, key, myRijndael.IV);
                    encryptedText = Methods.byteToHex(myRijndael.IV) + " " + Methods.byteToHex(encrypted);
                }

            }
            catch
            {
                Methods.errorMessage(errorText, "Error");
            }

            return encryptedText;
        }

        public static String Decrypt(String text)
        {
            String decryptedText = "";

            try
            {
                // Create a new instance of the RijndaelManaged 
                // class.  This generates a new key and initialization  
                // vector (IV). 
                using (RijndaelManaged myRijndael = new RijndaelManaged())
                {
                    // Encrypt the string to an array of bytes.

                    byte[] IV = Methods.byteSubstring(Methods.hexToByte(text), 0, 16);

                    string decrypted = DecryptStringFromBytes(Methods.byteSubstringAll(Methods.hexToByte(text), 16), key, IV);

                    decryptedText = decrypted;
                }

            }
            catch
            {
                Methods.errorMessage(errorText, "Error");
            }

            return decryptedText;
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption. 
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream. 
            return encrypted;
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold 
            // the decrypted text. 
            string plaintext = null;

            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream 
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }

        public static void generateKey() {
            try
            {
                using (RijndaelManaged myRijndael = new RijndaelManaged())
                {
                    myRijndael.GenerateKey();
                    key = myRijndael.Key;
                }
            }
            catch
            {
                Methods.errorMessage(errorText, "Error");
            }
        }
    }
}
