using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = null;

            try
            {
                F = new FileStream(@"D:\Share\Chandan.txt", FileMode.Open, FileAccess.Read);


                for (int i = 0; i < F.Length; i++)
                {
                    char j = (char)F.ReadByte();
                    Console.Write(j);
                }
                //F.Close();
                F.Dispose();

                Console.WriteLine((char)F.ReadByte());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
