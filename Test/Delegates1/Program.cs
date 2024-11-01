using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    delegate string StrMod(string s);
    class DelegatesTest
    {
        string q = "";
        public string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hypen");
            return s.Replace(" ", "-");
        }

        public string RemoveSpaces(string s)
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
            return q;
        }
        public string Reverse(string s)
        {
            string q = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                q += s[i];
            }

            return q;
        }
        
    }
        class Program
    {
        
        static void Main(string[] args)
        {
            DelegatesTest dt = new DelegatesTest();

            StrMod sm = dt.ReplaceSpaces;
            string test = "";

            test = sm("This is a Test.");
            Console.WriteLine(test);
            Console.WriteLine("\r\n");

            sm = dt.RemoveSpaces;
            test = sm("This is a test");
            Console.WriteLine(test);
            Console.WriteLine("\r\n");

            sm = dt.Reverse;
            test = sm("This is a test");
            Console.WriteLine(test);

            
        }
    }
}
