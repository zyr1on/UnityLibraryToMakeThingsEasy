# MyLibrary
My C# library For Unity 
<br>

<strong> Example Usage of Encryption Class: </strong> <a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L42">Line:42</a>
```cs
using UnityEngine;
using Library;
public class Example : MonoBehaviour
{
    void Start() 
    {
        string encrypted_data = Encryption.Encrypt("Hi"); // encrypts "hi" string;
        string decrypted_data = Encryption.Decrypt(encrypted_data); // Decrypts "encrypted_data" variable encrypted as "hi"
    }
}
```
!!! The Encryption Class encrypts and decrypts the string you pass the function (md5,tripleDES,base64 -> 
with given hash; <a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L45">Line:45</a>)

<strong>Example <strong>Usage</strong> of  ResetAllTransform Function: </strong>(<a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L36">Line:36</a>) 
```cs
using UnityEngine;
using Library;
public class Example : MonoBehaviour
{
    void Start() 
    {
        transform.ResetAllTransform(); // reset all transform values
        // or
        LibraryFunctions.ResetAllTransform(this.transform);
    }
}
```
