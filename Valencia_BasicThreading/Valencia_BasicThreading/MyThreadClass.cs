using System;
using System.Threading;

namespace Valencia_BasicThreading
{
    public class MyThreadClass
    {
        // Set by the form so thread output goes to txtOutput instead of the console.
        public static Action<string> Log;

        public static void Thread1()
        {
            // Loop ends on the fifth attempt (loopCount 0..5 as in Figure 2).
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Log?.Invoke("Name of Thread: " + thread.Name + " Process = " + loopCount);

                Thread.Sleep(1500); // suspend current thread for 1.5 seconds
            }
        }
    }
}
