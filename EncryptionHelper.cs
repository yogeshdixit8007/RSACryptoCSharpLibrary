using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;

public static class EncryptionHelper
{
    // Use static buffers for simplicity (or use interop-safe string return mechanisms)
    private static string lastResult = "";

    [UnmanagedCallersOnly(EntryPoint = "Encrypt", CallConvs = new[] { typeof(CallConvCdecl) })]
    public static IntPtr Encrypt(IntPtr inputPtr, IntPtr publicKeyPtr)
    {
        try
        {
            string input = Marshal.PtrToStringAnsi(inputPtr);
            string publicKey = Marshal.PtrToStringAnsi(publicKeyPtr);

            // TODO: Implement real RSA encryption logic here
            string encrypted = $"[ENCRYPTED:{input}]"; // Placeholder

            lastResult = encrypted;
            return Marshal.StringToHGlobalAnsi(lastResult);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "Decrypt", CallConvs = new[] { typeof(CallConvCdecl) })]
    public static IntPtr Decrypt(IntPtr encryptedInputPtr, IntPtr privateKeyPtr)
    {
        try
        {
            string encryptedInput = Marshal.PtrToStringAnsi(encryptedInputPtr);
            string privateKey = Marshal.PtrToStringAnsi(privateKeyPtr);

            // TODO: Implement real RSA decryption logic here
            string decrypted = $"[DECRYPTED:{encryptedInput}]"; // Placeholder

            lastResult = decrypted;
            return Marshal.StringToHGlobalAnsi(lastResult);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }
}
