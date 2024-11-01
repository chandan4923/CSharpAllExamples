using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll29
{
    class MyClass
    {
        char ch = 'A';

        public IEnumerable MyItr(int end)
        {
            for (int i = 0; i < end; i++)
            {
                yield return (char)(ch + i);
            }
        }

        public IEnumerable MyItr(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                yield return (char)(ch + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            foreach (char item in mc.MyItr(10))
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();


            foreach (char item in mc.MyItr(10, 26))
            {
                Console.Write(item + " ");
            }
        }
    }
}
