using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassArgumentsToMain
{
    class CLProgram
    {
        static int Main(string[] args)
        {
            //Console.WriteLine("THere are "+args.Length+" comman-line arguments.");

            //Console.WriteLine("They are: ");
            //for(int i=0;i<args.Length;i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            if(args.Length<2)
            {
                Console.WriteLine("Usage: encode/Decode Word1[word2....wordN]");
                return 1;
            }

            if(args[0].ToLower()!="encode"&args[0].ToLower()!="decode")
            {
                Console.WriteLine("First argument must be encode or decode");
                return 1;
            }

            for (int n = 1; n < args.Length; n++)
            {
                for (int i = 0; i < args[n].Length; i++)
                {
                    if (args[0].ToLower() == "encode")
                    {
                        Console.Write((args[n][i] + 1));
                        Console.Write(args[n][i]);
                    }
                    else
                    {
                        Console.Write((char)(args[n][i] - 1));
                    }

                }
                Console.Write(" ");
            }
            return 0;
        }
    }
}
