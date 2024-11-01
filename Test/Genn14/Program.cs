using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn14
{

    class ArrayUtils
    {
         public bool CopyArray<T>(T e, uint idx, T[]src, T[] tar)
        {
            if (src.Length > tar.Length)
            {
                return false;
            }
            else
            {
                int i, j;
                for (i = 0, j = 0; i < tar.Length; i++, j++)
                {
                    if (j == idx)
                    {
                        tar[j] = e;
                        j++;
                    }
                    if(i<src.Length)
                        tar[j] = src[i];
                }
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ArrayUtils au = new ArrayUtils();

            int[] n1 = new int[2] { 5,6};
            int[] n2 = new int[4];

            au.CopyArray(89, 3, n1, n2);

            foreach (var item in n2)
            {
                Console.WriteLine(item);
            }

            string[] st1 = new string[] { "CHANDAN", "SADASIVUNI" };
            string[] st2 = new string[5] ;

            au.CopyArray("JJ", 1, st1, st2);
            foreach (var item in st2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
