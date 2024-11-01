using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll9
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> ll = new LinkedList<char>();

            Console.WriteLine("Initial number of elements: " + ll.Count());

            Console.WriteLine("Adding 5 elements.");

            ll.AddFirst('A');
            ll.AddFirst('B');
            ll.AddFirst('C');
            ll.AddFirst('D');
            ll.AddFirst('E');

            Console.WriteLine("Number of elements: " + ll.Count());

            LinkedListNode<char> node;

            Console.WriteLine("Display contents by following links: ");

            for (node=ll.First;node!=null;node=node.Next)
            {
                Console.Write(node.Value+" ");
            }

            Console.WriteLine("Display contents in reverse by following links: ");

            for (node=ll.Last; node!=null; node=node.Previous)
            {
                Console.Write(node.Value + " ");
            }


            Console.WriteLine("Removing 2 elements and adding 6 elements at last");

            ll.Remove('C');
            ll.Remove('A');

            ll.AddLast('X');
            ll.AddLast('Y');
            ll.AddLast('Z');

            Console.WriteLine("Contents: ");

            foreach (var item in ll)
            {
                Console.Write(item + " ");
            }
        }
    }
}
