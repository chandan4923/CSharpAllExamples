using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll6
{
    class Program
    {
        static void ShowEnq(Queue q, int a)
        {
            q.Enqueue(a);

            Console.WriteLine("Enqueue(" + a + ")");

            Console.Write("Queue consists of: ");
            foreach (var item in q)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }

        static void ShowDeQ(Queue s)
        {
            int j = (int)s.Dequeue();
            Console.WriteLine("Dequeue(" + j + ")");

            Console.Write("Updated contents of Queue: ");
            foreach (var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Queue q = new Queue();

            ShowEnq(q, 22);
            ShowEnq(q, 65);
            ShowEnq(q, 91);
            ShowEnq(q, 125);

            ShowDeQ(q);
            ShowDeQ(q);
            ShowDeQ(q);
            ShowDeQ(q);

        }
    }
}
