using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL11
{
    class Program
    {
        static int[] data;

        static void MyTransform(int i, ParallelLoopState pls)
        {
            if (data[i] < 0) pls.Stop();

            data[i] = data[i] / 10;

            if (data[i] < 10000) data[i] = 0;
            if (data[i] > 10000 & data[i] < 20000) data[i] = 100;
            if (data[i] > 20000 & data[i] < 30000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread is running");

            data = new int[100000000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }


            data[1000] = -9;
            ParallelLoopResult loopResult=
            Parallel.For(0, data.Length, MyTransform);

            string s =loopResult.IsCompleted?
                "Loop completed successfully"
                :"\n Loop Terminated early because a "
                    +"negative value was encountered "
                    +" in loopiteration number "
                    + loopResult.LowestBreakIteration;

            Console.WriteLine(s);

            Console.WriteLine("Main thread is ending");
        }
    }
}
