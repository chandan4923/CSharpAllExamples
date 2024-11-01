using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL2
{
    class MyTask
    {
        public static void MyTaskRun()
        {
            Console.WriteLine("My Task with ID: " + Task.CurrentId + " is starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("In MyTask() with ID: "+Task.CurrentId+" and count is " + i);
            }
            Console.WriteLine("MyTask()with ID" + Task.CurrentId + " is terminating!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyTask mt1 = new MyTask();

            Task t1 = new Task(MyTask.MyTaskRun);
             Task t2 = new Task(MyTask.MyTaskRun);

            t1.Start();
            t2.Start();

            Console.WriteLine("Task ID for t1 is "+t1.Id);
            Console.WriteLine("Task ID for t2 is " + t2.Id);

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Main thread is ending");

        }
    }
}
