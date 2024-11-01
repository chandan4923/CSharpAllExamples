using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL7
{
    class Program
    {
        static void MyTask(object v)
        {
            CancellationToken cancellationToken = (CancellationToken)v;

            cancellationToken.ThrowIfCancellationRequested();

            Console.WriteLine("MyTask(0 is starting");

            for (int i = 0; i < 10; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Cancellation request has been received");
                    cancellationToken.ThrowIfCancellationRequested();
                }

                Thread.Sleep(500);
                Console.WriteLine("In MyTask(), count is: "+i);
            }

            Console.WriteLine("Task is terminating!");
        }
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Task tsk = Task.Factory.StartNew(MyTask, cts.Token, cts.Token);

            Thread.Sleep(2000);

            try
            {
                //cts.Cancel();
                //tsk.Wait();
            }
            catch (AggregateException ae)
            {

                Console.WriteLine("\ntsk cancelled");

                Console.WriteLine(ae);
            }
            finally
            {
                //cts.Dispose();
                tsk.Dispose();

            }
            Console.WriteLine("Main thread is ending");
        }
    }
}
