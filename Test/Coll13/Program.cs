using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();

            st.Push("One");
            st.Push("Two");
            st.Push("Three");
            st.Push("Four");
            st.Push("Five");

            while (st.Count>0)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
