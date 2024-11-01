using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> lst = new List<char>();

            Console.WriteLine("Initial number of elements: "+lst.Count());

            Console.WriteLine("Adding 6 elements.");

            lst.Add('C');
            lst.Add('A');
            lst.Add('E');
            lst.Add('B');
            lst.Add('D');
            lst.Add('F');

            Console.WriteLine("Number of elements: "+lst.Count());

            Console.WriteLine("Current contents: ");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            lst.Remove('F');
            lst.Remove('A');

            Console.WriteLine("Contents");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Adding 20 more elements.");

            for (int i = 0; i < 20; i++)
            {
                lst.Add((char)('a' + i));
            }

            Console.WriteLine("Current capacity: "+lst.Capacity);

            Console.WriteLine("Number of elements after adding 20 elements: " + lst.Count());

            foreach (var item in lst)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Change first three elements");

            lst[0] = 'X';
            lst[0] = 'Y';
            lst[0] = 'Z';


            Console.WriteLine("Contents");
            foreach (var item in lst)
            {
                Console.Write(item+" ");
            }
        }
    }
}
