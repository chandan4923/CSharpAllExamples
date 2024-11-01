using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll17
{
    class BlockingDemo
    {
        static BlockingCollection<char> bc;
        static void Producer()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                bc.Add(i);
                Console.WriteLine("Producing: " + i);
            }
            bc.CompleteAdding();
        }
        static void Consuming()
        {
            while (!bc.IsCompleted)
            {
                if(bc.TryTake(out char c))
                {
                    Console.WriteLine("Consuming: "+c);
                }
            }
        }
        static void Main(string[] args)
        {
            bc = new BlockingCollection<char>(4);

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
