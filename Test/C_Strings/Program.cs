using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace C_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "When it comes to .NET programming, C# is #1.";
            string str2 = "When it comes to .NET programming, C# is #1.";
            string str3 = "C# strings are powerful.";
            string strUp, strLow;
            int result, idx;

            //Console.WriteLine("str1: "+str1);
            //Console.WriteLine("length of str1: "+str1.Length);

            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            strUp = str1.ToUpper(CultureInfo.CurrentCulture);

            string[] str = { "When", "it", "comes", "to", ".NET", "programming,", "C#", "is", "#1." };
            for (int i = 0; i < str.Length; i++)
            {
                //Console.Write(str[i] + " ");
                //Console.WriteLine("\n");
            }

            int[] n = new int[20];

            string[] s1 = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            int x = 1908;
            int remainder = 0;
            int arrayNumber = 0;
            do
            {
                remainder = x % 10;
                n[arrayNumber] = remainder;
                arrayNumber++;
                x = x / 10;

            } while (x > 0);
            arrayNumber--;
            for (; arrayNumber>=0; arrayNumber--)
            {
                Console.Write(s1[n[arrayNumber]]+" ");
            }
            Console.WriteLine();
        }
    }
}
