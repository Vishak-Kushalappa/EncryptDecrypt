﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Cryptography_CSharp
    {
        //static String key = System.Configuration.ConfigurationManager.AppSettings["RequestEncryptionKey"].ToString();
        //static String key1 = System.Configuration.ConfigurationManager.AppSettings["RequestEncryptionKey1"].ToString();
        static String key = "VF8=$#P-U*MH_T]Z";
        static String key1 = "Q7~7*$G#;5@`C6^5";
        public static string Encrypt(string data)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;

            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }

            Array.Copy(pwdBytes, keyBytes, len);

            byte[] pwdBytes1 = Encoding.UTF8.GetBytes(key1);
            byte[] keyBytes1 = new byte[0x10];
            int len1 = pwdBytes1.Length;

            if (len1 > keyBytes1.Length)
            {
                len1 = keyBytes1.Length;
            }

            Array.Copy(pwdBytes1, keyBytes1, len1);

            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes1;
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(data);

            return Convert.ToBase64String
            (transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public static string Decrypt(string data)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] encryptedData = Convert.FromBase64String(data);
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;

            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }

            Array.Copy(pwdBytes, keyBytes, len);

            byte[] pwdBytes1 = Encoding.UTF8.GetBytes(key1);
            byte[] keyBytes1 = new byte[0x10];
            int len1 = pwdBytes.Length;

            if (len1 > keyBytes1.Length)
            {
                len1 = keyBytes1.Length;
            }

            Array.Copy(pwdBytes1, keyBytes1, len1);

            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes1;
            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock
                        (encryptedData, 0, encryptedData.Length);

            return Encoding.UTF8.GetString(plainText);
        }
    }
}