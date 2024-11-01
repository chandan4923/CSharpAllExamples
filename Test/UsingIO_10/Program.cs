using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter dataIn = null;
            BinaryReader dataOut=null;

            string item;
            int onhand;
            double cost;

            try
            {
                dataIn = new BinaryWriter(new FileStream("database.dbf", FileMode.Create));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                dataIn.Write("Chandan");
                dataIn.Write(1);
                dataIn.Write(3.95);

                dataIn.Write("Sadasivuni");
                dataIn.Write(18);
                dataIn.Write(1.50);

                dataIn.Write("Pilers");
                dataIn.Write(5);
                dataIn.Write(4.95);

                dataIn.Write("Saws");
                dataIn.Write(8);
                dataIn.Write(8.95);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(dataIn!= null)
                {
                    dataIn.Close();
                }
            }
            try
            {
                dataOut = new BinaryReader(new FileStream("database.dbf", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Enter item name to search");
                string s = Console.ReadLine();
                for(; ; )
                {
                    item = dataOut.ReadString();
                    onhand = dataOut.ReadInt32();
                    cost = dataOut.ReadDouble();
                    if (item.Equals(s,StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Values of the row are as below:");
                        Console.WriteLine(item+" "+onhand+" "+cost);
                        break;
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                dataOut.Close();
            }
        }
    }
}
