using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn17
{

    class Program
    {
        public static bool IsIn<T>(T v, T[] arr)where T:IEquatable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //if (arr[i] == v)
                if (arr[i].Equals(v))

                {
                    return true;
                }
                
            }
            return false;
        }
        static void Main(string[] args)
        {
        }
    }
}
