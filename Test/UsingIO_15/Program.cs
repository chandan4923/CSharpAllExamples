using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_15
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\Users\csadasiv\Desktop\Chandan3.txt"))
            { 
                Console.WriteLine("The last accessed time is: " + File.GetLastAccessTimeUtc(@"C:\Users\csadasiv\Desktop\Chandan3.txt"));
            Console.WriteLine("The created time is: " + File.GetCreationTime(@"C:\Users\csadasiv\Desktop\Chandan3.txt"));
        }
        else
        {
                Console.WriteLine("File do not exists");
        }
}
    }
}
