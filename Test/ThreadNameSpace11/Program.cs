using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace11
{
    class MyThread
    {
        public Thread thrd;

        public MyThread(string name)
        {
            thrd = new Thread(Run);

            thrd.Name = name;

            thrd.Start();
        }

        void Run()
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i + " ");

                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                        Thread.Sleep(500);
                    }

                }
            }
            catch(ThreadAbortException e)
            {
                if ((int)e.ExceptionState == 0)
                {
                    Console.WriteLine("Cancelling Abort and resetting it");

                    Thread.ResetAbort();
                }
                else
                {
                    Console.WriteLine("Not Cancelling abort!");
                }

            }

            Console.WriteLine(thrd.Name + " existing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread(" My Thread");

            Thread.Sleep(1000);

            Console.WriteLine("Stopping thread");

            mt.thrd.Abort(100);

            Console.WriteLine("Stopping thread");

            mt.thrd.Abort(0);


            mt.thrd.Join();

            Console.WriteLine("Main thread is terminating!");
        }
    }
}
