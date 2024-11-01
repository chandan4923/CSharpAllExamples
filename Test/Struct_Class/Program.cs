using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Class
{
    struct Book
    {
        public int CopyRight;
        public string Author;
        public string Title;

        public Book(string a, string b, int x)
        {
            this.Author = a;
            Title = b;
            CopyRight = x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //string A = "CHANDAN SADASIVUNI";

            //char[] X = new char[A.Length];

            //for(int i= 0; i < X.Length; i++)
            //{
            //    X[i] = A[X.Length-1-i];
            //    Console.Write(X[i]);
            //}
            
 
            Book B1 = new Book("Herb Schildt", "C# 4.0: The Complete Refernce", 2010);
            Book B2 = new Book();

            Book B3;
            B3.Author = "CHANDAN SADASIVUNI";

            B3.Title = "MY LIFE";

            B3.CopyRight = 1994;

            Console.WriteLine(B1.Author+" "+B1.Title+" "+B1.CopyRight);
            Console.WriteLine(B2.Author+" "+B2.Title+" "+B2.CopyRight);
            B2.CopyRight = 19988;
            B2.Author = "ATEEKSH";
            B2.Title = "HHH";
            Console.WriteLine(B2.Author+" "+B2.Title+" "+B2.CopyRight);
            Console.WriteLine(B3.Author+" "+B3.Title+" "+B3.CopyRight);
        }
    }
}
