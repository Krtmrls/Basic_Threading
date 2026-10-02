using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThread
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            // loopCount 0 to 5, then the thread ends
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

                Thread.Sleep(1500);   // suspend for 1.5 seconds
            }
        }
    }
}