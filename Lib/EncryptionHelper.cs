using System;
using System.Security.Cryptography;
using System.Text;

public static class EncryptionHelper
{
    private static readonly string hash = "your-secure-key-here";
    public static string EncryptSHA256(string input) {
        byte[] data = Encoding.UTF8.GetBytes(input);
        using (SHA256 sha256 = SHA256.Create()) {
            byte[] keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(hash));
            byte[] truncatedKey = new byte[24];
            Array.Copy(keyBytes, truncatedKey, 24);
            using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider
            {
                Key = truncatedKey,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            })
            {
                tripDes.GenerateIV();
                byte[] iv = tripDes.IV;
                using (ICryptoTransform encryptor = tripDes.CreateEncryptor())
                {
                    byte[] results = encryptor.TransformFinalBlock(data, 0, data.Length);

                    // Prepend IV for use in decryption
                    byte[] combinedResults = new byte[iv.Length + results.Length];
                    Array.Copy(iv, 0, combinedResults, 0, iv.Length);
                    Array.Copy(results, 0, combinedResults, iv.Length, results.Length);
                    return Convert.ToBase64String(combinedResults);
                }
            }
        }
    }
    public static string EncryptMD5DES(string input) {
        byte[] data = UTF8Encoding.UTF8.GetBytes(input);
        using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()) 
        {
            byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            using(TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider(){Key = key,Mode = CipherMode.ECB,Padding = PaddingMode.PKCS7}) 
            {
                ICryptoTransform tr = trip.CreateEncryptor();
                byte[] results = tr.TransformFinalBlock(data,0,data.Length);
                return Convert.ToBase64String(results);
            }
        }
    }
    
    public static string DecryptSHA256(string input) {
        byte[] combinedData = Convert.FromBase64String(input);
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(hash));
            byte[] truncatedKey = new byte[24];
            Array.Copy(keyBytes, truncatedKey, 24);
            using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider
            {
                Key = truncatedKey,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            })
            {
                byte[] iv = new byte[tripDes.BlockSize / 8];
                byte[] ciphertext = new byte[combinedData.Length - iv.Length];
                Array.Copy(combinedData, iv, iv.Length);
                Array.Copy(combinedData, iv.Length, ciphertext, 0, ciphertext.Length);
                tripDes.IV = iv;
                using (ICryptoTransform decryptor = tripDes.CreateDecryptor())
                {
                    byte[] results = decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
                    return Encoding.UTF8.GetString(results);
                }
            }
        }
    }
    public static string DecryptMD5DES(string input) {
        byte[] data = Convert.FromBase64String(input);
        using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()) 
        {
            byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            using(TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() {Key = key,Mode = CipherMode.ECB,Padding = PaddingMode.PKCS7}) 
            {
                ICryptoTransform tr = trip.CreateDecryptor();
                byte[] results = tr.TransformFinalBlock(data,0,data.Length);
                return UTF8Encoding.UTF8.GetString(results);
            }
        }
    }
}
