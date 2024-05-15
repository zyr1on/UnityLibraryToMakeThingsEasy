# MyLibrary
My C# library For Unity 
<br>

<strong> Example Usage of Encryption Class: </strong> <a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/EncryptionHelper.cs#L5">Line:5</a>
```cs
using UnityEngine;
public class Example : MonoBehaviour
{
    void Start()
    {
        string encrypted_data;
        string decrypted_data;

        encrypted_data = EncryptionHelper.EncryptMD5DES("Hi");
        decrypted_data = EncryptionHelper.DecryptMD5DES(encrypted_data);
        // SHA256 more secure!
        encrypted_data = EncryptionHelper.EncryptSHA256("Hi");
        decrypted_data = EncryptionHelper.DecryptSHA256(encrypted_data);
    }
}
```
!!! The provided code snippet uses the MD5 with TripleDES (3DES) and SHA256 algorithms for the encryption process. <br>The EncryptionHelper Class encrypts and decrypts the string you pass the function (md5,tripleDES,base64 -> 
with given hash; <a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/EncryptionHelper.cs#L7">Line:7</a>)

<br>
<strong>Example <strong>Usage</strong> of  RunFuncWithSecs Function: </strong>(<a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/TimeUtils.cs#L7">Line:7</a>) 

```cs
using UnityEngine;
public class example : MonoBehaviour
{
    void Start()
    {
        TimeUtils.RunFuncsWithSecs(func1,func2,3); // after 3 seconds func1 runs and after 3 seconds func2 runs for once(cuz start method);
    }
    void Update()
    {
        // after 5 secs func1 runs and after 5 seconds func2 runs and this goes on and on(cuz update method)
        TimeUtils.RunFuncsWithSecs(func1,func2,5);
        TimeUtils.RunFuncWithSecs(other_func,5); //after 5 secs other_func runs and after 5 secs func1 runs and this goes on and on;
    }
}
```

<br>
<strong>Example <strong>Usage</strong> of ScreenBounds struct </strong>(<a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/ScreenBounds.cs#L4">Line:4</a>) 

```cs
using UnityEngine;
public class example : MonoBehaviour
{
    ScreenBounds bounds;
    void Start()
    {
        bounds = ScreenBounds.GetScreenBounds();
        Debug.Log(bounds.min.x);
    }
    void Update()
    {
        if(transform.position.y < bounds.min.y) {
            // DO THINGS
        }
    }
}
```

