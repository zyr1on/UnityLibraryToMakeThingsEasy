# MyLibrary
My C# library For Unity 
<br>

<strong> Example Usage of Encryption Class: </strong> <a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/Encryption.cs#L5">Line:5</a>
```cs
using UnityEngine;
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
with given hash; <a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/Encryption.cs#L6">Line:6</a>)

<br>
<strong>Example <strong>Usage</strong> of  RunFuncWithSecs Function: </strong>(<a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/TimeUtils.cs#L7">Line:7</a>) 

```cs
using UnityEngine;
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

