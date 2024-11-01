using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class optionalParameters
    {
        public static void OptArgMeth(int alpha, int beta=9,int gamma=20)
        {
            Console.WriteLine("Alpha: "+alpha+" Beta: "+beta+" Gamma: "+gamma);
        }
    }
    
    class Program
    {
        static void Display(string str, int start = 0, int stop = -1)
        {
            if (stop < 0)
                stop = str.Length;
            if (stop < start | start < 0 | stop > str.Length)
                return;

            for(int i=start;i<str.Length;i++)
                Console.Write(str[i]);

            Console.WriteLine();

        }
        static bool IsFactor(int val,int div)
        {
            if (val % div == 0) return true;

            return false;
        }
        static void Main(string[] args)
        {
            //optionalParameters.OptArgMeth(1);
            //optionalParameters.OptArgMeth(1,2);
            //optionalParameters.OptArgMeth(1,2,3);
            //Display("My Name is Chandan Sadasivuni");
            //Display("My Name is Chandan Sadasivuni",10,15);
            //Display("My Name is Chandan Sadasivuni",5);
            //Display("My Name is Chandan Sadasivuni",5,2);
            Console.WriteLine(   IsFactor(10, 2));
           Console.WriteLine(IsFactor(div: 9, val: 81));
           

        }
    }
}
