/*
using Library;
Library.Library myLb = new Library.Library();
myLb.Functions...
*/
using UnityEngine;
namespace Library 
{
    public class Library : MonoBehaviour
    {
        public float timer;
        public bool moveDir;
        public delegate void SomeDelegate();
        
        public void RunFuncWithSecs // Run 2 Function with given secs,RunFuncWithSecs(givenFunc1,givenFunc2,givenSec);
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
}
