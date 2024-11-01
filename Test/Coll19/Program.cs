using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll19
{
    class Inventory
    {
        string name;
        double cost;
        int onhand;

        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1}$ On Hand: {2}", name, cost, onhand);
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<Inventory> inv = new List<Inventory>();

                inv.Add(new Inventory("Pilers", 5.5, 3));
                inv.Add(new Inventory("Wrenches", 8.29, 2));
                inv.Add(new Inventory("Hammers", 3.50, 4));
                inv.Add(new Inventory("Drills", 19.58, 8));


                Console.WriteLine("Inventory List: ");

                foreach (var item in inv)
                {
                    Console.WriteLine(item.ToString());
                }

            }
        }
    }
}
