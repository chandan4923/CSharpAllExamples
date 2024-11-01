using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll5
{
    class Program
    {

        static void ShowPush(Stack s, int a)
        {
            s.Push(a);

            Console.WriteLine("Push("+a+")");

            Console.Write("Stack consists of: ");
            foreach (var item in s)
            {
                Console.Write(item+" ");
                
            }
            Console.WriteLine();
        }
        static void ShowPop(Stack s)
        {
            int j=(int)s.Pop();
            Console.WriteLine("Pop("+j+")");

            Console.Write("Updated contents of stack: ");
            foreach (var item in s)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }
                static void Main(string[] args)
        {

            Stack s = new Stack();

            ShowPush(s, 42);
            ShowPush(s, 65);
            ShowPush(s, 16);
            ShowPush(s, 100);

            ShowPop(s);
            ShowPop(s);
            ShowPop(s);
        }
    }
}
