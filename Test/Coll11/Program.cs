using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll11
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> sdict = new SortedDictionary<string, double>();

            sdict.Add("Butter, John", 73000);
            sdict.Add("Swartz, Sarah", 59000);
            sdict.Add("Pyke, Thomas", 45000);
            sdict.Add("Frank, Ed", 99000);

            ICollection<string> c = sdict.Keys;

            foreach (var item in c)
            {
                Console.WriteLine(item + " " + sdict[item]);
            }

        }
    }
}
