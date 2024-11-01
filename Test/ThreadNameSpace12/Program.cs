using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadNameSpace12
{
    class Program
    {
        static void Main(string[] args)
        {

            Process process = Process.Start(@"C:\Users\csadasiv\Downloads\how_is_the_interest_calculated (1).pdf");

            process.WaitForExit();

            process.Close();



            

            
        }
    }
}
