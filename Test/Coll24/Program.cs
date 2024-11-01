using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll24
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            var o = list.GetEnumerator();

            while (o.MoveNext())
            {
                Console.Write(o.Current+" ");
            }

            Console.WriteLine();

            o.Reset();

            while (o.MoveNext())
            {
                Console.Write(o.Current + " ");
            }

            Console.WriteLine();
        }
    }
}
