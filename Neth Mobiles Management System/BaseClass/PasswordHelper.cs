using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public static class PasswordHelper
{
    public static byte[] GenerateSalt()
    {
        byte[] saltBytes = new byte[16];
        using (var provider = new RNGCryptoServiceProvider())
        {
            provider.GetBytes(saltBytes);
        }
        return saltBytes;
    }

    public static byte[] HashPassword(string password, byte[] saltBytes)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] combinedBytes = Encoding.UTF8.GetBytes(password).Concat(saltBytes).ToArray();
            return sha1.ComputeHash(combinedBytes);
        }
    }

    public static bool VerifyPassword(string password, byte[] storedHashBytes, byte[] storedSaltBytes)
    {
        byte[] hashedPasswordBytes = HashPassword(password, storedSaltBytes);
        return hashedPasswordBytes.SequenceEqual(storedHashBytes);
    }
}



