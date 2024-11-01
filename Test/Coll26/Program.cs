using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll26
{
    class MyClass : IEnumerator, IEnumerable
    {
        char[] chrs = { 'A', 'B', 'C', 'D' };
        int idx = -1;
        public object Current {
            get { return chrs[idx]; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (idx == chrs.Length - 1)
            {
                Reset();

                return false;
            }

            idx++;
            return true;
        }

        public void Reset()
        {
            idx = -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            foreach (char item in mc)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();

            foreach (char item in mc)
            {
                Console.Write(item + " ");
            }

        }
    }
}
