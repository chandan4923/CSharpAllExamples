using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll22
{
    class CompInv : IComparer
    {
        public int Compare(object x, object y)
        {
            Inventory a = (Inventory)x;
            Inventory b = (Inventory)y;

            return string.Compare(a.name,b.name,StringComparison.Ordinal);
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
            CompInv comp = new CompInv();
            ArrayList inv = new ArrayList();

            inv.Add(new Inventory("Pilers", 5.5, 3));
            inv.Add(new Inventory("Wrenches", 8.29, 2));
            inv.Add(new Inventory("Hammers", 3.50, 4));
            inv.Add(new Inventory("Drills", 19.58, 8));

            Console.WriteLine("Inventory List: ");

            foreach (var item in inv)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            inv.Sort(comp);


            Console.WriteLine("Inventory list after sorting: ");
            foreach (var item in inv)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();



        }
    }
}
