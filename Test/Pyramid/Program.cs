using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {

        public void Print(int k)
        {
            int i = 1;
            int j=0;
            while (j!=k)
            {
                for (j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }
                int x = i;
                for (j=0; j < 1000/i; j++)
                {
                    if(j%2!=0)
                        Console.Write("|");
                    i++;
                }
                //int y;
                //for (j =0; j < i; j++)
                //{
                //    Console.Write(" ");
                //}
                Console.WriteLine();
                i = x;
                i++;
            }
            }
        static void Main(string[] args)
        {
            //int i = 1;
            Program P = new Program();
            P.Print(4);
            
        }
    }
}
