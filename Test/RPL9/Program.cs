using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL9
{
    class Program
    {
        static int[] data;

        static void MyTransform(int i)
        {
            data[i] = data[i] / 10;

            if (data[i] < 10000) data[i] = 0;
            if (data[i] > 10000 & data[i] < 20000) data[i] = 100;
            if (data[i] > 20000 & data[i] < 30000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread is starting!");

            data = new int[100000000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            Parallel.For(0, data.Length, MyTransform);


            Console.WriteLine("Main thread is ending!");
        }
    }
}
