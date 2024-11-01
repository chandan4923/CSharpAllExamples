using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL1
{
    class Program
    {
        static void MyTask()
        {
            Console.WriteLine("My Task is starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("In MyTask(), count is "+i);
            }
            Console.WriteLine("MyTask() is terminating!");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread is starting");
            Task task = new Task(MyTask);

            task.Start();

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Main thread is ending");
        }
    }
}
