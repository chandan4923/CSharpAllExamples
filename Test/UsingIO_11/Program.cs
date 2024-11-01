using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_11
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = null;
            BinaryReader br = null;
            FileStream fs = null;
            try
            {
                //bw = new BinaryWriter(new FileStream("Test.txt", FileMode.Create));
                fs = new FileStream("Test1.txt", FileMode.Create);
                for (int i = 0; i < 26; i++)
                {
                    fs.WriteByte((byte)('A' + i));
                    
                }
                //string s = "My name is Chandan";
                //string[] c = s.Split();
                //char[] x= new char[] { };
                //for (int i = 0; i < c.Length; i++)
                //{
                //    x = c[i].ToCharArray();

                //    foreach (var item in x)
                //    {
                //        fs.Write((byte)item);
                //    }
                //}
                

                //br = new BinaryReader(new FileStream("Test.txt", FileMode.Open));

                //bw.See
                fs.Seek(1, SeekOrigin.Begin);

                Console.WriteLine((char)fs.ReadByte());


                fs.Seek(0, SeekOrigin.Begin);
                Console.WriteLine((char)fs.ReadByte());

                for (int i = 0; i < 26; i+=2)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    Console.WriteLine((char)fs.ReadByte());
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //fs.Close();
            }
            
        }
    }
}
