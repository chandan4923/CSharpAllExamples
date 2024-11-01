using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class DelegatesTest
    {
        string q = "";
        public static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hypen");
            return s.Replace(" ", "-");
        }

        public static string RemoveSpaces(string s)
        {
            string q= "";
            Console.WriteLine("Removing spaces");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]!=' ' )
                {
                    q += s[i];
                }
            }
            return q;
        }

        public static string Reverse(string s)
        {
            string q = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                q += s[i];
            }

            return q;
        }
    }


    delegate string StrMod(string s);
    class Program
    {
        static void Main(string[] args)
        {
            //StrMod sm = new StrMod(DelegatesTest.ReplaceSpaces);
            StrMod sm = Delegates.DelegatesTest.ReplaceSpaces;
            string test = "";  
                
                test=sm("This is a Test.");
            Console.WriteLine(test);
            Console.WriteLine("\r\n");


            //sm = new StrMod(DelegatesTest.RemoveSpaces);

           sm = DelegatesTest.RemoveSpaces;
            test = sm("This is a test");
            Console.WriteLine(test);
            Console.WriteLine("\r\n");

            //sm = new StrMod(DelegatesTest.Reverse);
            sm = DelegatesTest.Reverse;
            test = sm("This is a test");
            Console.WriteLine(test);
            //Console.WriteLine("\r\n");

        }
    }
}
