using UnityEngine;
public static class TimeUtils {
    static float timer = 0.0f;
    static bool goFor = true;
    public delegate void SomeDelegate(); 
    // Runs 2 Function with given secs,RunFuncWithSecs(givenFunc1,givenFunc2,givenSec)
    public static void RunFuncsWithSecs(SomeDelegate delegate1, SomeDelegate delegate2, float Secs)
    {
        timer += Time.deltaTime;
        if(timer >= Secs) {
            timer = 0.0f;
            if(goFor) delegate1();
            else delegate2();
            goFor = !goFor;
        }
    }

    public static void RunFuncWithSecs(SomeDelegate someDelegate,float secs)
    {
        timer += Time.deltaTime;
        if(timer >= secs) {
            someDelegate();
            timer = 0.0f;
        }
    }
}
