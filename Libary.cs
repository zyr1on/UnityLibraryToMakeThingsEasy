using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{
    
    
    // Run 2 Function with given secs
    // Library.RunFuncWithSecs(givenFunc1,givenFunc2,givenSec);
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
        if(timer >= Secs) // Library.RunWithSecs(func1,func2,second);
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
