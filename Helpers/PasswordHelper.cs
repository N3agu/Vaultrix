using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Vaultrix.Helpers {
    public static class PasswordHelper{
        public static void StoreHashedPassword(string vaultPassword, string keyFilePath, string vaultFilePath) {
            byte[] salt = GenerateSalt();
            string hashedPassword = HashPasswordWithSalt(vaultPassword, salt);
            
            string saltPlusHash = Convert.ToBase64String(salt) + ":" + hashedPassword;

            // Encrypt (DPAPI)
            byte[] protectedData = ProtectedData.Protect(Encoding.UTF8.GetBytes(saltPlusHash), null, DataProtectionScope.CurrentUser);

            File.WriteAllBytes(keyFilePath, protectedData);
            File.Create(vaultFilePath).Close();
        }

        public static bool ValidatePassword(string enteredPassword, string keyFilePath) {
            byte[] protectedData = File.ReadAllBytes(keyFilePath);

            // Decrypt (DPAPI)
            byte[] unprotectedData = ProtectedData.Unprotect(protectedData, null, DataProtectionScope.CurrentUser);

            string saltPlusHash = Encoding.UTF8.GetString(unprotectedData);
            string[] parts = saltPlusHash.Split(':');
            
            if (parts.Length != 2)
                throw new InvalidOperationException("Stored password format is incorrect.");

            byte[] storedSalt = Convert.FromBase64String(parts[0]);
            string storedHashedPassword = parts[1];

            string enteredHashedPassword = HashPasswordWithSalt(enteredPassword, storedSalt);

            // Compare the entered hashed password with the stored one
            return storedHashedPassword == enteredHashedPassword;
        }

        // PBKDF2
        private static string HashPasswordWithSalt(string password, byte[] salt) {
            using (Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, salt, 10000)) {
                return Convert.ToBase64String(rfc2898.GetBytes(32)); // Hash size = 32 bytes
            }
        }

        private static byte[] GenerateSalt() {
            byte[] salt = new byte[16]; // Salt size = 16 bytes
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public static bool UsernameContainsInvalidCharacters(string username) {
            char[] invalidChars = Path.GetInvalidFileNameChars();

            if(string.IsNullOrEmpty(username))
                return true;

            if (username.Contains(" "))
                return true;

            return username.Any(c => invalidChars.Contains(c));
        }
    }
}
