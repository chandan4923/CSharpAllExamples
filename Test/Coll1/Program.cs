using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Initial number of elements: "+al.Count);
            Console.WriteLine("Initial capacity of arraylist: "+al.Capacity);


            Console.WriteLine("Adding 6 elements.");

            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('B');
            al.Add('D');
            al.Add('F');

            Console.WriteLine("Number of elements: " + al.Count);
            Console.WriteLine("Capacity of arraylist: " + al.Capacity);

            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("removing 2 elements");
            al.Remove('F');
            al.Remove('A');

            Console.WriteLine("Number of elements: " + al.Count);

            Console.WriteLine("Contents: ");
            foreach (var item in al)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();


            Console.WriteLine("Adding 20 more eleements");

            for (int i = 0; i < 20; i++)
            {
                al.Add((char)('a' + i));
            }

            Console.WriteLine("Current capacity: "+al.Capacity);

            Console.WriteLine("Number of elements: " + al.Count);

            Console.WriteLine("Contents: ");
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
