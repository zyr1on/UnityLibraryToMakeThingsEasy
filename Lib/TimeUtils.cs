using UnityEngine;
public static class TimeUtils {
    static float timer = 0;
    static bool goFor;
    public delegate void SomeDelegate(); 
    // Runs 2 Function with given secs,RunFuncWithSecs(givenFunc1,givenFunc2,givenSec)
    public static void RunFuncWithSecs(SomeDelegate delegate1, SomeDelegate delegate2, float Secs)
    {
        timer += Time.deltaTime;
        if (timer >= Secs)
        {
            timer = 0.0f;
            goFor = !goFor;
        }
        if (goFor)
            delegate1();
        else
            delegate2();
    }

    public static void RunFunc(SomeDelegate someDelegate,float secs)
    {
        timer += Time.deltaTime;
        if(timer > secs) {
            someDelegate();
            timer = 0;
        }
    }
}
