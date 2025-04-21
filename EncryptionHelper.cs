using System;
using System.Runtime.InteropServices;

public static class EncryptionHelper
{
    [DllExport("Encrypt", CallingConvention = CallingConvention.Cdecl)]
    public static string Encrypt(string input, string publicKey)
    {
        // Encryption logic here
        return "EncryptedData";
    }

    [DllExport("Decrypt", CallingConvention = CallingConvention.Cdecl)]
    public static string Decrypt(string encryptedInput, string privateKey)
    {
        // Decryption logic here
        return "DecryptedData";
    }
}
