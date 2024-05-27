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
<strong>Example <strong>Usage</strong> of ScreenBounds struct </strong>(<a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/ScreenBounds.cs#L4">Line:4</a>) 

```cs
using UnityEngine;
public class example : MonoBehaviour
{
    ScreenBounds bounds; // defined here!!
    void Start()
    {
        bounds = ScreenBounds.GetScreenBounds();
        Debug.Log(bounds.min.x);
    }
    void Update() //or FixedUpdate() depends on you
    {
        if(transform.position.y > bounds.max.y || transform.position.y < bounds.min.y) { // its more like if the y coordinate of the gameObject(this) exceeds the limit
            // DO THINGS
        }
        // Or you can use Like this
        Mathf.Clamp(transform.position.x,bounds.min.x,bounds.max.x);
    }
}
```

<br>
<strong>Example <strong>Usage</strong> of FileUtilities </strong>(<a href="https://github.com/zyr1on/MyLibrary/blob/main/Lib/FileUtilities.cs#L4">Line:4</a>) 

```cs
    void Start()
    {
        DataType myData = new DataType(); // or it can be anything like struct, enum, string...
        FileUtilities.WriteAsJson(myData,path); // The file was saved to given path as json as obj type.
        // you can save as string
        DataType otherData = FileUtilities.ReadAsJson<Data>(DataType);
        /* It reads the contents from file with given path variable and then assigns it to the other "otherData variable" with its own type.
        / So, our new otherData changes to readed values from ReadAsJson.
        / And that way we can create a simple save system with json.
        / Save()->WriteAsJson Load()->ReadAsJson<datatype>(); (lets assume datatype is a collection of variableas of our game datas).
        */
    }
```

