using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLINQ1
{
    class Program
    {
        static int[] data;
        static void Main(string[] args)
        {
            data = new int[100000000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            data[1000] = -1;
            data[10000] = -6;
            data[20000] = -10;
            data[35000] = -2;
            data[40000] = -9;

           var ts= from var in data.AsParallel()
            where var < 0
            select var;

            for (int i = 0; i < ts.ToList().Count; i++)
            {
                Console.WriteLine(ts.ToList()[i]);
            }

            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
