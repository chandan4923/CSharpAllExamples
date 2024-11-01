using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL5
{
    class Program
    {
        static void MyTask()
        {
            Console.WriteLine("My Task is starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("In MyTask(), count is " + i);
            }
            Console.WriteLine("MyTask() is terminating!");
        }

        static void  MyTaskContinuation(Task t)
        {
            Console.WriteLine("Continuation is starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("In Continuation task, count is " + i);
            }
            Console.WriteLine("Continuation is terminating!");

        }
            static void Main(string[] args)
        {
            //Task tsk = Task.Factory.StartNew(MyTask);
            Task tsk = new Task(MyTask);

            Task tskContinuation = tsk.ContinueWith(MyTaskContinuation);

            tsk.Start();

            //tskContinuation.Wait();

            tsk.Dispose();
            tskContinuation.Dispose();

            Console.WriteLine("Main thread is ending!");
        }
    }
}
