using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coll4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("house", "Dwelling");
            sl.Add("car", "Means of transport");
            sl.Add("book", "Collection of printed words");
            sl.Add("apple", "Edible fruit");

            sl["tracktor"] = "Farm implement";

            ICollection ic = sl.Keys;

            Console.WriteLine("Content of list via indexer:");

            foreach (var item in ic)
            {
                Console.WriteLine(item+": "+sl[item]);
            }

            Console.WriteLine();

            Console.WriteLine("Contents by integer indexes.");

            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine(sl.GetByIndex(i));
            }

            Console.WriteLine();

            Console.WriteLine("Integer indexes of entries");

            foreach (var item in ic)
            {
                Console.WriteLine(item +": "+sl.IndexOfKey(item));
            }

        }
    }
}
