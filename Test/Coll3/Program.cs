using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("house", "Dwelling");
            ht.Add("car", "Means of transport");
            ht.Add("book", "Collection of printed words");
            ht.Add("apple", "Edible fruit");

            ht["tracktor"] = "Farm implement";

            ICollection c = ht.Keys;


            foreach (var str in c)
            {
                Console.WriteLine(str + " " + ht[str]);
            }
        }
    }
}
