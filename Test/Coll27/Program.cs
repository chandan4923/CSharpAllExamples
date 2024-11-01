using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll27
{
    class MyClass
    {
        char[] chrs = { 'A', 'B', 'C', 'D' };

        public IEnumerator GetEnumerator()
        {
            foreach (char ch in chrs)
            {
                yield return ch;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            foreach (var item in mc)
            {
                Console.Write(item+ " ");
            } 
        }
    }
}
