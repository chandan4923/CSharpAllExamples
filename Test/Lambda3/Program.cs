using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda3
{
    delegate void strMod(ref string s);
    class Program
    {
        static void Main(string[] args)
        {
            strMod ReplaceSpaces =(ref string j) =>
            {
                Console.WriteLine("Replacing space with hypens");
                //return j.Replace(' ', '-');
               j= j.Replace(' ', '-');
            };

            strMod RemoveSpaces = (ref string j) =>
            {
                string q ="";
                Console.WriteLine("Removing spaces");
                for (int i = 0; i < j.Length; i++)
                {
                    if (j[i] != ' ')
                    {
                        q = q+j[i];
                    }
                }
                //return q;
                j = q;
            };

            strMod Reverse = (ref string n) =>
            {
                string s = "";
                Console.WriteLine("Reversing String");
                for (int i = n.Length; i > 0; i--)
                {
                    s = s + n[i-1];
                }

                //return s;
            };


            string z = "My name is Chandan Sadasivuni";

            strMod str = ReplaceSpaces;
            

            //Console.WriteLine(str(z));
            str += RemoveSpaces;
            str(ref z);
            Console.WriteLine(z);
            //Console.WriteLine(str(z));
            //Console.WriteLine(Reverse(z));
        }
    }
}
