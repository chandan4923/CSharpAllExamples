using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll12
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, double> sl = new SortedList<string, double>();

            sl.Add("Butter, John", 73000);
            sl.Add("Swartz, Sarah", 59000);
            sl.Add("Pyke, Thomas", 45000);
            sl.Add("Frank, Ed", 99000);

            ICollection<string> c = sl.Keys;

            foreach (string item in c)
            {
                Console.WriteLine(item+" "+sl[item]);
            }

        }
    }
}
