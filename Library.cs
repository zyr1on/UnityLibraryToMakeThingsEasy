/*
using Library;
Library.className <myClass> = new Library.className();
<myClass>.Attributes();
*/
using System;
using System.Text;
using System.Security.Cryptography;
using UnityEngine;
namespace Library 
{
    public class LibraryFunctions
    {
        public float timer;
        public bool goFor;
        public delegate void SomeDelegate(); 

        // Runs 2 Function with given secs,RunFuncWithSecs(givenFunc1,givenFunc2,givenSec)
        public void RunFuncWithSecs (
            SomeDelegate delegate1,
            SomeDelegate delegate2, 
            float Secs
        ) {
            timer += Time.deltaTime;
            if(timer >= Secs) // Library.RunWithSecs(func1,func2,second);
            {
                timer = 0.0f;
                goFor = !goFor;
            }
            if(goFor) 
                delegate1();
            else 
                delegate2();
        }
        
        // reset all transform values
        public Void ResetAllTransform(this Transform trans) { 
            trans.position = Vector3.zero; // (0,0,0)
            trans.localRotation = Quaternion.identity;
            trans.localScale = new Vector3(1,1,1);
        }
    }
    public class Encryption //The Encryption Class encrypts and decrypts the string you pass the function
    {
        private string hash = "JunkHash@foo"; // Change Here;
        public string Encrypt(string input) 
        {
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
        public string Decrypt(string input) 
        {
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
}
