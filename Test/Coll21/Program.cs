using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll21
{
    class Inventory : IComparable<Inventory>
    {
        string name;
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
        public int CompareTo(Inventory other)
        {
            return string.Compare(name, other.name, StringComparison.Ordinal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Inventory> linv = new List<Inventory>();

            linv.Add(new Inventory("Pilers", 5.5, 3));
            linv.Add(new Inventory("Wrenches", 8.29, 2));
            linv.Add(new Inventory("Hammers", 3.50, 4));
            linv.Add(new Inventory("Drills", 19.58, 8));

            Console.WriteLine("Inventory List: ");

            foreach (var item in linv)
            {
                Console.WriteLine(item.ToString());
            }

            linv.Sort();

            Console.WriteLine("Inventory list after sorting: ");
            foreach (var item in linv)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
