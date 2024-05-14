# MyLibrary
My C# library For Unity 
<br>

<strong> Example Usage of Encryption Class: </strong> <a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L38">Line:38</a>
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
with given hash; <a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L40">Line:40</a>)
<br>
<strong>Example <strong>Usage</strong> of  ResetAllTransform Function: </strong>(<a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L33">Line:33</a>) 
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
<br>
<strong>Example <strong>Usage</strong> of  RunFuncWithSecs Function: </strong>(<a href="https://github.com/zyr1on/MyLibary/blob/main/Library.cs#L16">Line:16</a>) 

```cs
using UnityEngine;
using Library;
public class example : MonoBehaviour
{
    void Start()
    {
        TimeUtils .RunFuncWithSecs(func1,func2,3); // first func1 runs and after 3 seconds func2 runs for once(cuz start method);
    }
    void Update()
    {
        // first func1 runs and after 5 seconds func2 runs and this goes on and on(cuz update method)
        TimeUtils .RunFuncWithSecs(func1,func2,5);
    }
}
```
