using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            double d = 10.99;
            bool b = true;
            string s = "Chandan is my name";
            BinaryWriter bw = null;
            BinaryReader br = null;
            try
            {
                bw = new BinaryWriter(new FileStream("Chandan.txt", FileMode.Create));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                
                bw.Write(i);
                bw.Write(d );
                bw.Write(b);
                bw.Write(s);

            }
            catch (IOException e)
            {
               
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (bw != null)
                {
                    bw.Close();
                }
            }

            try
            {
                br = new BinaryReader(new FileStream("Chandan.txt", FileMode.Open));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
                try
                {
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadDouble());

                Console.WriteLine(br.ReadBoolean());
                Console.WriteLine(br.ReadString());

            }
            catch (IOException e){
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                if(br != null)
                {
                    br.Close();
                }
            }
            }
    }
    }
