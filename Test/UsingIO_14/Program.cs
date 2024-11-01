using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingIO_14
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { @"C:\Users\csadasiv\Desktop\Chandan.doc", @"C:\Users\csadasiv\Desktop\Chandan3.txt"};
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: CopyFile From To");
                return;
            }
            //try
            //{
            //    File.Copy(args[0], args[1],true);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            FileStream F1 = new FileStream(args[0], FileMode.Open);
            //FileStream f = new FileStream()
            FileStream F2 = new FileStream(args[1], FileMode.Create);
            StreamReader sr = new StreamReader(F1, Encoding.UTF8);
            StreamWriter sw = new StreamWriter(F2,Encoding.UTF8);
            //int j;

            try
            {
                bool s = true;
                while (s)
                {
                    if (F1.ReadByte() != -1)
                    {
                        //sw.Write(sr.ReadToEnd());
                        sw.Write(Encoding.UTF8.GetChars((char)F1.Read()));
                        sw.Write((char)F1.ReadByte());
                    }
                    //sw.Write("My Name is Chandan");
                    //Console.Write((char)F1.ReadByte());
                    else
                        s = false;
                }
                //Thread.Sleep(5);

            }
            catch(IOException)
            {

            }
            finally
            {
              
                //F2.Close();
                
                sw.Flush();
                F2.Flush();
                sw.Close();
                F2.Close();
                //F1.Close();
            }
            
        
        }
    }
}
