using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll14
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> q = new Queue<double>();

            q.Enqueue(98.6);
            q.Enqueue(212.0);
            q.Enqueue(32.0);
            q.Enqueue(3.1416);

            double sum = 0.0;

            foreach (var item in q)
            {
                sum += item;
                Console.WriteLine("Sum is: "+sum);
            }
            Console.WriteLine();
            sum = 0.0;
            while (q.Count>0)
            {
                sum += q.Dequeue();
                Console.WriteLine("Sum is: " + sum);
            }
            sum = 0.0;
            Console.WriteLine();
            foreach (var item in q)
            {
                sum += item;
                Console.WriteLine("Sum is: " + sum);
            }
            Console.WriteLine();


        }
    }
}
