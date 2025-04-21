using System;
using System.Security.Cryptography;
using System.Text;

namespace MyCSharpLibrary
{
    public class EncryptionHelper
    {
        public string Encrypt(string input, string publicKey)
        {
            // Encryption logic here using publicKey
            var encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
            return encrypted;
        }

        public string Decrypt(string encryptedInput, string privateKey)
        {
            // Decryption logic here using privateKey
            var decrypted = Encoding.UTF8.GetString(Convert.FromBase64String(encryptedInput));
            return decrypted;
        }
    }
}
