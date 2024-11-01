using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll28
{
    class MyClass
    {
        char ch = 'A';

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
            {
                if (i == 10) { yield break; }
                yield return (char)(ch + i);
            }

            //yield return 'A';
            //yield return 'B';
            //yield return 'C';
            //yield return 'D';
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            foreach (var item in mc)
            {
                Console.Write(item+" ");
            }
        }
    }
}
