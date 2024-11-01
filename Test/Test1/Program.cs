using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 6, 5, 2, 4, 8, 7 };
            
            int[] b = new int[a.Length];
            int t;
            
            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j] & i < a.Length)
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                    
                }
            }
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
