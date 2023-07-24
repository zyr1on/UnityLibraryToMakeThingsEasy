# MyLibrary
C# library For Unity
To Use:

```cs
using Library;
Library.className <myClass> = new Library.className();
```
Example Usage of Chipher Class;
```cs
using Library;
Library.Encryption myChipher = new Library.Encryption();
myChipher.Encrypt("Hi");
myChipher.Decrypt();
```
The Encryption Class encrypts and decrypts the string you pass the function (with given hash; Look at Code)
