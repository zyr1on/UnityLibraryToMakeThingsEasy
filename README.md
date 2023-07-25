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
using UnityEngine;
using Library;
public class Example : MonoBehaviour
{
    void Start() 
    {
        string encrypted_data = Encryption.Encrypt("Hi");
        Debug.Log(encrypted_data);
        string decrypted_data = Encryption.Decrypt(encrypted_data);
    }
}
```
The Encryption Class encrypts and decrypts the string you pass the function
(with given hash; <a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L44">Line:44</a>)

Example <strong>Usage</strong> of  ResetAllTransform Function (<a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L36">Line:36</a>)
```cs
using UnityEngine;
using Library;
public class Example : MonoBehaviour
{
    void Start() 
    {
        transform.ResetAllTransform(); // reset all transform values
    }
}
```
