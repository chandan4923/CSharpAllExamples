using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{

    public class Destruct
    {
        int x;
        public Destruct(int i)
        {
            x = i;
        }

        ~Destruct()
        {
            Console.WriteLine("Destructing " +x);
        }

        public void Generator(int i)
        {
            Destruct o = new Destruct(i);
        }
    }
    class Program
    {



        static void Main(string[] args)
        {

            //int[][] network_nodes = new int[4][];
            //network_nodes[0] = new int[3];
            //network_nodes[1] = new int[5];
            //network_nodes[2] = new int[6];
            //network_nodes[3] = new int[4];

            //for (int i = 0; i < network_nodes.Length; i++)
            //{
            //    for (int j = 0; j < network_nodes[i].Length; j++)
            //    {
            //        network_nodes[i][j] = (i * j) + 70;


            //    }
            //}

            //Console.WriteLine("Length of nework nodes is:" +network_nodes.Length);

            //for (int i = 0; i < network_nodes.Length; i++)
            //{
            //    for (int j = 0; j < network_nodes[i].Length; j++)
            //    {
            //        Console.Write("CPU usuage at node "+i+" CPU "+j+" ");
            //        Console.Write(network_nodes[i][j]+" % \n");
            //    }
            //}
            //Console.WriteLine();

            //var q = new[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //            var jagged = new[]
            //            { new[]{ 1,2,3,7},
            //            new[]{3,6,7},
            //            new[]{9,10,23}
            //};

            //            for(int i = 0;i < jagged.Length;i++)
            //                {
            //                for (int j = 0; j < jagged[i].Length; j++)
            //                {
            //                    Console.Write(jagged[i][j] +"\t");
            //                }
            //                Console.WriteLine();
            //            }

            char[] chararray = { 'A', ' ', 'S', 'T', 'R', 'I', 'N', 'G', 'A', 'R', 'R', 'A', 'Y' };

            string s1 = new string(chararray);

            Console.WriteLine(s1);

            


        }
    }
}
