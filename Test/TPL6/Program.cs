using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL6
{
    class Program
    {
        static bool MyTask()
        {
            return true;
        }

        static int SumIt(object v)
        {
            int x = (int)v;

            int Sum = 0;
            for (; x>0; x--)
            {
                Sum += x;
                //Console.WriteLine(x);
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main trhead is starting");
        
        Task<bool> tsk = Task<bool>.Factory.StartNew(MyTask);

            Console.WriteLine("After running My Task. The result is: "+tsk.Result);

            Task<int> tskSum = Task<int>.Factory.StartNew(SumIt, 1000000);

            Console.WriteLine("After running SumIt task. The result is: " + tskSum.Result);

            tsk.Dispose();
            tskSum.Dispose();

            Console.WriteLine("Main thread is ending");


        }
    }
}
