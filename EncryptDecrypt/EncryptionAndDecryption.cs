using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace EncryptDecrypt
{
    public class EncryptionAndDecryption
    {        
        # region EncryptAndDecrypt
        public EncryptionAndDecryption()
        {

        }
        # endregion

        # region Encryption
        public string Encryption(String TextToEncrypt, String PasswordKey)
        {
            string EncryptedPassword = "";
            try
            {
                if (TextToEncrypt != null)
                {
                    RijndaelManaged RijndaelCipher = new RijndaelManaged();
                    byte[] PlainText = Encoding.Unicode.GetBytes(TextToEncrypt);
                    if (PasswordKey != null && PasswordKey.Length > 0)
                    {
                        byte[] Salt = Encoding.ASCII.GetBytes(PasswordKey.Length.ToString());
                        PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(PasswordKey, Salt);
                        ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
                        MemoryStream memoryStream = new MemoryStream();
                        CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
                        cryptoStream.Write(PlainText, 0, PlainText.Length);
                        cryptoStream.FlushFinalBlock();
                        byte[] CipherBytes = memoryStream.ToArray();
                        memoryStream.Close();
                        cryptoStream.Close();
                        EncryptedPassword = Convert.ToBase64String(CipherBytes);
                    }
                }
            }
            catch (Exception ex)
            {
                EncryptedPassword = "";
            }
            return EncryptedPassword;

        }
        # endregion

        # region Decryption
        public string Decryption(String TextToDecrypt, String PasswordKey)
        {         
            string DecryptedPassword = "";
            try
            {
                if (TextToDecrypt != null)
                {
                    RijndaelManaged RijndaelCipher = new RijndaelManaged();
                    byte[] EncryptedData = Convert.FromBase64String(TextToDecrypt);
                    if (PasswordKey != null && PasswordKey.Length > 0)
                    {
                        byte[] Salt = Encoding.ASCII.GetBytes(PasswordKey.Length.ToString());
                        PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(PasswordKey, Salt);
                        ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
                        MemoryStream memoryStream = new MemoryStream(EncryptedData);
                        CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);
                        byte[] PlainText = new byte[EncryptedData.Length];
                        int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
                        memoryStream.Close();
                        cryptoStream.Close();
                        DecryptedPassword = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);
                    }
                }
            }
            catch (Exception ex)
            {
                DecryptedPassword = "";                
            }            
            return DecryptedPassword;
        }
        #endregion
    }
}
