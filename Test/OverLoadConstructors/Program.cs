using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadConstructors
{
    class MyClass
    {
        public int x;
        public MyClass()
        {
            Console.WriteLine("Constructor of this class is only MyClass()");
            x = 0;
        }
        public MyClass(int i)
        {
            Console.WriteLine("Construcor of this class is MyClass(int i)");
            x = i;
        }
        public MyClass(double d)
        {
            Console.WriteLine("Constructor of this class is MyClass(double d)");
            x = (int)d;
        }
        public MyClass(int i, int j)
        {
            Console.WriteLine("Constructor of this class is MyClass(int i, int j)");
            x = i * j;
        }
    }

    class Stack
    {
        char[] stck;
        int tos;

        public Stack(int size)
        {
            stck = new char[size];
            tos = 0;
        }
        public Stack(Stack ob)
        {
            stck = new char[ob.stck.Length];

            for (int i = 0; i < ob.stck.Length; i++)
            {
                stck[i] = ob.stck[i];
            }
            tos = ob.tos;
        }

        public void Push(char ch)
        {
            if(tos==stck.Length)
            {
                Console.WriteLine("--Stack is full");
            }

            stck[tos] = ch;
            tos++;
        }
        public char Pop()
        {
            if(tos==0)
            {
                Console.WriteLine("--Stack is empty");
            return (char)0;

            }
            tos--;
            return stck[tos];
        }

        public bool IsFull()
        {
            return tos == stck.Length;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
        public int Capacity()
        {
            return stck.Length;
        }
        public int GetNum()
        {
            return tos;
        }
    }
    class XYCoordinate
    {
        public int x, y;
        public XYCoordinate(int i, int j)
        {
            x = i;
            y = j;
            Console.WriteLine("Values of X and Y are: "+x+" "+y);
            
        }
        public XYCoordinate():this(23,67)
        {
            Console.WriteLine("It calls parameters less contructor as well as (int,int) constructor");
        }
        public XYCoordinate(XYCoordinate ob):this(ob.x,ob.y)
        {
            Console.WriteLine("It calls XYConstructor(XYCoordinate reference) contructor as well as (int,int) constructor");
        }

        public XYCoordinate(int x):this(x,x)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass c1 = new MyClass();
            //MyClass c2 = new MyClass(10);
            //MyClass c3 = new MyClass(9.475);
            //MyClass c4 = new MyClass(76, 98);

            //Console.WriteLine(c1.x);
            //Console.WriteLine(c2.x);
            //Console.WriteLine(c3.x);
            //Console.WriteLine(c4.x);

            //Stack s1 = new Stack(6);
            //for (int i = 0; i < s1.Capacity(); i++)
            //{
            //    s1.Push((char)('A' + i));
            //}
            //Stack s2 = new Stack(s1);


            //while(!s1.IsEmpty())
            //{
            //    Console.WriteLine("s1 Contents: "+ s1.Pop());

            //}

            //Console.WriteLine("---------");
            //while (!s2.IsEmpty())
            //{
            //    Console.WriteLine("s2 Contents: " + s2.Pop());

            //}

            XYCoordinate xYCoordinate = new XYCoordinate();
            XYCoordinate xYCoordinate1 = new XYCoordinate(54, 98);
            XYCoordinate xYCoordinate2 = new XYCoordinate(xYCoordinate);

            Console.WriteLine(xYCoordinate.x+" "+xYCoordinate.y);
            Console.WriteLine(xYCoordinate1.x+" "+xYCoordinate1.y);
            Console.WriteLine(xYCoordinate2.x+" "+xYCoordinate2.y);

        }
    }
}
