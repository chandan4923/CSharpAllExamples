using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll30
{
    class MyClass<T>
    {
        T[] array;

        public MyClass(T[] tarr)
        {
            array = tarr;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in array)
            {
                yield return item;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 4, 3, 6, 7, 9 };

            MyClass<int> gmc = new MyClass<int>(nums);

            

            foreach (var item in gmc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            bool[] b = { true, false, true, true, false };

            MyClass<bool> gmc1 = new MyClass<bool>(b);

            foreach (var item in gmc1)
            {
                Console.Write(item + " ");
            }
         }
    }
}
