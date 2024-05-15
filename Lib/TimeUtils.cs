using UnityEngine;

public static class TimeUtils
{
    private static float timer = 0.0f;
    private static bool goFor = true;
    private static bool firstCall = true;
    public enum CallType
    {
        Immediate,
        Unimmediate
    }
    public delegate void SomeDelegate();
    public static void RunFuncsWithSecs(SomeDelegate delegate1, SomeDelegate delegate2, float secs, CallType callType = CallType.Unimmediate)
    {
        if(callType == CallType.Immediate) {
            if(firstCall) {
                delegate1();
                firstCall = false;
            }
            timer += Time.deltaTime;
            if (timer >= secs) {
                timer = 0.0f;
                if (goFor) delegate2();
                else delegate1();
                goFor = !goFor;
            }
        }
        else {
            if (timer >= secs) {
                timer = 0.0f;
                if (goFor) delegate1();
                else delegate2();
                goFor = !goFor;
            }
        }
        
    }
    public static void RunFuncWithSecs(SomeDelegate someDelegate, float secs, CallType callType = CallType.Unimmediate) {
        if(callType == CallType.Immediate) {
            if(firstCall) {
                someDelegate();
                firstCall = false;
            }
        }
        timer += Time.deltaTime;
        if (timer >= secs) {
            someDelegate();
            timer = 0.0f;
        }
    }
}
