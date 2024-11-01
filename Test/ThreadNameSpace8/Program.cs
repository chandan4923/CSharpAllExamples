using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace8
{
    class MyThread
    {
        Thread thrd;

        ManualResetEvent manualReset;
        public MyThread(string name, ManualResetEvent mrEvent)
        {
            thrd = new Thread(Run);
            thrd.Name = name;
            manualReset = mrEvent;
            thrd.Start();
        }

        void Run()
        {
            Console.WriteLine("Inside "+thrd.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(thrd.Name);
                Thread.Sleep(500);
            }
            manualReset.Set();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            bool value = false;
            ManualResetEvent resetEvent = new ManualResetEvent(value);
            MyThread mt = new MyThread("Class #1", resetEvent);

            Console.WriteLine("Main thread waiting for event");

            
            resetEvent.WaitOne();

            Console.WriteLine("Main thread received the event");

            resetEvent.Reset();

            mt = new MyThread("Class #2", resetEvent);

            resetEvent.WaitOne();

            Console.WriteLine("Main thread received second event");


        }
    }
}
