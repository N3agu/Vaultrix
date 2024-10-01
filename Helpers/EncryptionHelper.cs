using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Vaultrix.Helpers
{
    public static class EncryptionHelper
    {
        public static string EncryptString(string plainText, string username, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = DeriveKey(password);
                aesAlg.IV = DeriveIV(username);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        public static string DecryptString(string cipherText, string username, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = DeriveKey(password);
                aesAlg.IV = DeriveIV(username);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static byte[] DeriveKey(string password) {
            using (SHA256 sha256 = SHA256.Create()) {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static byte[] DeriveIV(string username) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(username));
                byte[] iv = new byte[16]; // AES IV is 16 bytes
                Array.Copy(hash, iv, iv.Length);
                return iv;
            }
        }
    }
}