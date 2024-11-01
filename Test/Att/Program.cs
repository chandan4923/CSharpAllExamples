using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute:Attribute
    {
        string pri_remark;

        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
        }
        public string RemarK
        {
            get {

                return pri_remark;
                    }
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Chandan);

            Console.WriteLine("Attribute in:"+t.Name);

            object[] objAttributes = t.GetCustomAttributes(false);
            foreach(object o in objAttributes)
            {
                Console.WriteLine(o);
            }

            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute attribute = (RemarkAttribute)Attribute.GetCustomAttribute(t, tRemAtt);

            Console.WriteLine(attribute.RemarK);
         }
    }
    [Remark("THis is chandan's attribute")]
    class Chandan
    {
        Program Program = new Program();
    }
}
