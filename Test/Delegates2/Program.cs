using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    delegate void StrMod(ref string s);
    class DelegatesTest
    {
        string q = "";

        
        public static void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Replacing spaces with hypen");
            s.Replace(" ", "-");
        }

        public static void RemoveSpaces(ref string s)
        {
            string q = "";
            Console.WriteLine("Removing spaces");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    q += s[i];
                }
            }
            s = q;
        }
        public static void Reverse(ref string s)
        {
            Console.WriteLine("Reversing the string");
            string q = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                q += s[i];
            }

            s = q;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            StrMod sm;
            StrMod dReplacespace = DelegatesTest.ReplaceSpaces;
            StrMod dRemoveSpace = DelegatesTest.RemoveSpaces;
            StrMod dReverse = DelegatesTest.Reverse;


            //sm = new StrMod(dReplacespace);
            sm = dRemoveSpace;
            sm += dReverse;
           
            
            string s = "This is Test";

            sm(ref s);

            Console.WriteLine("Resulting String:" +s);


            sm -= dReverse;
            sm += dReplacespace;
            s = "This is Test";
            sm(ref s);
            Console.WriteLine("Resulting String:" + s);

        }
    }
}
