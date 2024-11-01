using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class ThreeDimensional
    {
        int x, y, z;

        public ThreeDimensional()
        {
            x = y = z = 0;
        }
        public ThreeDimensional(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }
        public static ThreeDimensional operator +(ThreeDimensional ob1, ThreeDimensional ob2)
        {
            var ob = new ThreeDimensional();
            ob.x = ob1.x + ob2.x;
            ob.y = ob1.y + ob2.y;
            ob.z = ob1.z + ob2.z;

            return ob;
        }

        public static ThreeDimensional operator -(ThreeDimensional ob1, ThreeDimensional ob2)
        {
            var ob = new ThreeDimensional();
            ob.x = ob1.x - ob2.x;
            ob.y = ob1.y - ob2.y;
            ob.z = ob1.z - ob2.z;

            return ob;
        }

        public void Show()
        {
            Console.WriteLine(x + " " + y + " " + z);
        }

        public static ThreeDimensional operator -(ThreeDimensional ob)
        {
            ThreeDimensional R = new ThreeDimensional();

            R.x = -ob.x;
            R.y = -ob.y;
            R.z = -ob.z;

            return R;
        }
        public static ThreeDimensional operator ++(ThreeDimensional ob)
        {
            ThreeDimensional result = new ThreeDimensional();

            result.x = ob.x + 1;
            result.y = ob.y + 1;
            result.z = ob.z + 1;

            return result;
        }

        public static ThreeDimensional operator +(ThreeDimensional ob, int number)
            {
            ThreeDimensional result = new ThreeDimensional();
            result.x = ob.x + number;
            result.y = ob.y + number;
            result.z = ob.z + number;

            return result;
            }
        public static bool operator <(ThreeDimensional ob1,ThreeDimensional ob2)
        {
            if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) < Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.z * ob2.z))
                return true;
            else
                return false;
                    }
        public static bool operator >(ThreeDimensional ob1, ThreeDimensional ob2)
        {
            if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) > Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.z * ob2.z))
                return true;
            else
                return false;
        }

        public static bool operator true(ThreeDimensional ob)
        {
            if (ob.x != 0 | ob.y != 0 | ob.z != 0) return true;
            else return false;
        }
        public static bool operator false(ThreeDimensional ob) {
            if (ob.x <= 0 && ob.y <= 0 && ob.z <= 0) return false;
            else return true;
        }

        public static ThreeDimensional operator --(ThreeDimensional ob)
        {
            ThreeDimensional result = new ThreeDimensional();
            result.x =ob.x-1;
            result.y =ob.y- 1;
            result.z =ob.z- 1;
            return result;
        }
        public static bool operator &(ThreeDimensional ob1,ThreeDimensional ob2)
        {
            if ((ob1.x != 0 && ob1.y != 0 && ob1.z != 0) & (ob2.x != 0 && ob2.y != 0 && ob2.z != 0)) return true;
            else return false;
        }

        public static bool operator |(ThreeDimensional ob1, ThreeDimensional ob2)
        {
            if ((ob1.x != 0 || ob1.y != 0 || ob1.z != 0) | (ob2.x != 0 || ob2.y != 0 || ob2.z != 0)) return true;
            else return false;
        }

        public static bool operator !(ThreeDimensional ob)
        {
            if (ob.x!=0||ob.y!=0||ob.z!=0) return false;
            else return true;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            ThreeDimensional o ;
            var o1 = new ThreeDimensional(74, 55, 48);
            
            var o2 = new ThreeDimensional(14, 15, 18);

            o1.Show();
            o2.Show();
            o = o1 + o2;
            o.Show();
            o=o1 - o2;
            o.Show();

            o++;
            o.Show();

            o = -o1;
            o.Show();

            o = o +o2 + 10;
            o.Show();

            if (o1 > o2) Console.WriteLine("o1 is greater than o2");
            else Console.WriteLine("o1 is not greater than o2");

            do
            {
                o2.Show();
                o2--;
            } while (o2);
        }
    }
}
