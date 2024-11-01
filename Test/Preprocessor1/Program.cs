//#define EXPERIMENTAL
#define DEP


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessor1
{
    class internalProgram
    {
        internal int x;
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region Mine

#if EXPERIMENTAL
                        {
                            Console.WriteLine("Compiled for experimental version");
                        }
#elif DEP
            {
                Console.WriteLine("Compiled for Dep Version");


            }

#else
                        {
            Console.WriteLine( "Compiled not for experimental version" );

            }
#endif
            #endregion Mine
            {
                //#warning Chandan is here
                Console.WriteLine("This is in all versions");

                internalProgram @internal = new internalProgram();
                @internal.x
            
            }

    }
    }
}