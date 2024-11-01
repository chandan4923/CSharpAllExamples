using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll23
{
    class CInventory : IComparer<Inventory>
    {
        public int Compare(Inventory x, Inventory y)
        {
            return string.Compare(x.name, y.name, StringComparison.Ordinal);
        }
    }

    class Inventory
    {
        public string name;
        double cost;
        int onhand;

        public Inventory(string n, double c, int o)
        {
            name = n;
            cost = c;
            onhand = o;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1}$ On Hand: {2}", name, cost, onhand);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CInventory ci = new CInventory();
            List<Inventory> li = new List<Inventory>();

            li.Add(new Inventory("Pilers", 5.5, 3));
            li.Add(new Inventory("Wrenches", 8.29, 2));
            li.Add(new Inventory("Hammers", 3.50, 4));
            li.Add(new Inventory("Drills", 19.58, 8));

            Console.WriteLine("Inventory List: ");

            foreach (var item in li)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            li.Sort(ci);

            Console.WriteLine("Inventory list after sorting: ");
            foreach (var item in li)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

        }
    }
}
