using System;
using System.Threading;

namespace Valencia_ThreadPriority
{
    public class MyThreadClass
    {
        public static Action<string> Log;

        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Log?.Invoke("Name of Thread: " + thread.Name + " Process = " + loopCount);

                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Log?.Invoke("Name of Thread: " + thread.Name + " Process = " + loopCount);

                Thread.Sleep(1500);
            }
        }
    }
}
