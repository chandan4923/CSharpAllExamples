using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace2
{

    class MyThread
    {
        public long count;

        public bool stop;

        public Thread thrd;

        public string currentName;
        public MyThread(string name)
        {
            count = 0;
            thrd = new Thread(this.Run);

            thrd.Name = name;

            currentName = name;

            
        }

        public void Run()
        {
            Console.WriteLine(thrd.Name+" is running!");
            do
            {
                count++;
                //if(currentName!= thrd.Name)
                {
                    currentName = thrd.Name;

                    Console.WriteLine("In "+currentName);
                }

            } while (stop==false && count<10000000000);

            stop = true;

            Console.WriteLine(thrd.Name+" terminating");


        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyThread myThread = new MyThread("High Priority!");

            MyThread myThread1 = new MyThread("Low Priority!");

            myThread.thrd.Priority = ThreadPriority.AboveNormal;
            myThread1.thrd.Priority = ThreadPriority.BelowNormal;

            myThread.thrd.Start();
            myThread1.thrd.Start();

            myThread.thrd.Join();
            myThread1.thrd.Join();

            Console.WriteLine();

            Console.WriteLine(myThread.thrd.Name+" thread counted to "+myThread.count);
            Console.WriteLine(myThread1.thrd.Name+" thread counted to "+myThread1.count);
        }
    }
}
