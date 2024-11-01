using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace10
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
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + " ");

                if (i % 10 == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(500);
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

            mt.thrd.Abort();

            mt.thrd.Join();

            Console.WriteLine("Main thread is terminating!");
        }
    }
}
