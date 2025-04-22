using System;
using System.Runtime.InteropServices;
using System.Text;

public static class EncryptionHelper
{
    [UnmanagedCallersOnly(EntryPoint = "Encrypt")]
public static IntPtr Encrypt(IntPtr inputPtr, IntPtr publicKeyPtr)
{
    string input = Marshal.PtrToStringUTF8(inputPtr)!;
    string publicKey = Marshal.PtrToStringUTF8(publicKeyPtr)!;

    string result = "EncryptedData: " + input;
    return Marshal.StringToCoTaskMemUTF8(result);
}

[UnmanagedCallersOnly(EntryPoint = "Decrypt")]
public static IntPtr Decrypt(IntPtr encryptedPtr, IntPtr privateKeyPtr)
{
    string encrypted = Marshal.PtrToStringUTF8(encryptedPtr)!;
    string privateKey = Marshal.PtrToStringUTF8(privateKeyPtr)!;

    string result = "DecryptedData: " + encrypted;
    return Marshal.StringToCoTaskMemUTF8(result);
}

}
