using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);

            

            foreach (var i in al)
            {
                Console.WriteLine(i+" ");
            }

            Console.WriteLine();

            int[] ia = (int[])al.ToArray(typeof(int));
            int sum = 0;

            for (int i = 0; i < ia.Length; i++)
            {
                sum += ia[i];

                Console.WriteLine("Sum is: "+sum);
            }
        }
    }
}
