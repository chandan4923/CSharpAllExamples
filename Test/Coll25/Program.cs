using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll25
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();


            ArrayList i = new ArrayList() { 1, "Chandan" };
            ht.Add("Tom", "555-3456");
            ht.Add("Mary", "555-9876");
            ht.Add("Todd", "555-3452");
            ht.Add("Ken", "555-7756");

          var ic=  ht.GetEnumerator();

            Console.WriteLine("Display information in the entry:");

            while (ic.MoveNext())
            {
                Console.WriteLine(ic.Entry.Key+" "+ic.Entry.Value);
            }

            Console.WriteLine();

            ic.Reset();

            Console.WriteLine("Display information using key and value directly:");

            while (ic.MoveNext())
            {
                Console.WriteLine(ic.Key + " " + ic.Value);
            }
        }
    }
}
