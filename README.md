# MyLibrary
My C# library For Unity 
<br>
To Use:

```cs
using Library;

Library.className <myClass> = new Library.className();
<myClass>.Attributes();
```
Example <strong>Usage</strong> of Encryption Class;
```cs
using Library;

Library.Encryption myChipher = new Library.Encryption();
```
<strong>And</strong>
```cs
myChipher.Encrypt("Hi");           // Encrypts "Hi"
myChipher.Decrypt(encrypted.data); // Decrypt encrypted.data (string)
```
The Encryption Class encrypts and decrypts the string you pass the function
(with given hash; <a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L45">Line:45</a>)
