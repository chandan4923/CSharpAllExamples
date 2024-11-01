using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll15
{
    class Program
    {
        static void Show(string msg, HashSet<char> set)
        {
            Console.WriteLine(msg);
            foreach (var ch in set)
            {
                Console.Write(ch+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            HashSet<char> hA = new HashSet<char>();
            HashSet<char> hB = new HashSet<char>();

            hA.Add('A');
            hA.Add('B');
            hA.Add('C');

            hB.Add('C');
            hB.Add('D');
            hB.Add('E');

            hA.SymmetricExceptWith(hB);

            Show("Set A after supersetting with B ", hA);

            hA.Intersect(hB);

            Show("Set A after intersecting with B ", hA);

            hA.ExceptWith(hB);

            Show("Set A after excepting with B", hA);
        }
    }
}
