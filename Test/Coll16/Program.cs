using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll16
{
    class BlockingDemo
    {
        static BlockingCollection<char> bc;
        static void Producer()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                bc.Add(i);
                Console.WriteLine("Producing: "+i);
            }
        }

        static void Consuming()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("Consuming "+bc.Take());
            }
        }
        static void Main(string[] args)
        {
            bc = new BlockingCollection<char>(1);

            Task prod = new Task(Producer);
            Task con = new Task(Consuming);

            prod.Start();
            con.Start();

            try
            {
                Task.WaitAll(prod, con);

            }
            catch (AggregateException ex)
            {

                Console.WriteLine(ex);
            }
            finally
            {
                prod.Dispose();
                con.Dispose();
                bc.Dispose();
            }

        }
    }
}
