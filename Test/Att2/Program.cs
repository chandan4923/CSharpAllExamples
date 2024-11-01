using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att2
{
    public class RemarkAttribute : Attribute
    {
        string pri_remark;
        public string Supplement;
        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
            Supplement = "NONE";
            Priority = 1;
        }

        public string Remark
        {
            get
            {
                return pri_remark;
            }
        }
        public int Priority { get; set; }
    }

    class ChandanAttribute : Attribute
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(UseAttribute);

            Console.WriteLine("Attributes in " + t.Name);

            object[] attribs = t.GetCustomAttributes(false);

            foreach (var o in attribs)
            {
                Console.WriteLine(o);
            }

            Type tRematt = typeof(RemarkAttribute);

            RemarkAttribute ra = (RemarkAttribute)Attribute.GetCustomAttribute(t, tRematt);

            Console.WriteLine("Remark & Supplement % Priority: ");
            Console.WriteLine(ra.Remark + " " + ra.Supplement+" "+ra.Priority);
        }
    }
    [Remark("This class uses an attribute class", Supplement = "This is an additional info!", Priority =2551)]
    [Chandan()]
    class UseAttribute
    {

    }
}
