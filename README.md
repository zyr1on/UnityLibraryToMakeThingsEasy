# MyLibrary
My C# library For Unity 
<br>
To Use:

```cs
using Library;
Library.className <myClass> = new Library.className();
<myClass>.Attributes();
```
Example <u>Usage</u> of Encryption Class;
```cs
using Library;
Library.Encryption myChipher = new Library.Encryption();
```
and 
```cs
myChipher.Encrypt("Hi");
myChipher.Decrypt();
```
The Encryption Class encrypts and decrypts the string you pass the function (with given hash; Look at Code)
