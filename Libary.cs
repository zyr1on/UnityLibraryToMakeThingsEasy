using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libary : MonoBehaviour
{
    
    
    public static float timer;
    public static bool moveDir;
    public delegate void SomeDelegate();        
    public static void RunFuncWithSecs
    (
        SomeDelegate delegate1,
        SomeDelegate delegate2, 
        float Secs
    ) 
    {
        timer += Time.deltaTime;
        if(timer >= Secs) // Libary.RunWithSecs(func1,func2,second);
        {
            timer = 0.0f;
            moveDir = !moveDir;
        }
        if(moveDir) 
            delegate1();
        else 
            delegate2();
    }
}
