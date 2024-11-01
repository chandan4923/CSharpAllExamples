using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();

            dict.Add("Butter, John", 73000);
            dict.Add("Swartz, Sarah", 59000);
            dict.Add("Pyke, Thomas", 45000);
            dict.Add("Frank, Ed", 99000);

            ICollection c = dict.Keys;

            foreach (var item in c)
            {
                Console.WriteLine(item+" "+dict[(string)item]);
            }
        }
    }
}
