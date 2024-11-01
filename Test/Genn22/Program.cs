using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn22
{
     public interface IMyCoVarGenIF<out T>
        {

        T GetObject();
}

    class MyClass<T> : IMyCoVarGenIF<T>
    {
        T obj;

        public MyClass(T v)
        {
            obj = v;
        }
        public T GetObject()
        {
            return obj;
        }
    }

    class Alphas
    {
        string name;
        public Alphas(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Beta:Alphas
    {
        public Beta(string n):base(n)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            IMyCoVarGenIF<Alphas> AlphaRef = new MyClass<Alphas>(new Alphas("Chandan Alpha"));

            string name=AlphaRef.GetObject().GetName();

            Console.WriteLine(name);


            AlphaRef = new MyClass<Beta>(new Beta("Chandan Beta"));

            name = AlphaRef.GetObject().GetName();

            Console.WriteLine(name);
        }
    }
}
