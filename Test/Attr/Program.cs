using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attr
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string pr_remark;
        public RemarkAttribute(string comment)
        {
            pr_remark = comment;
        }


    }
    [Remark("My name is")]
    class Chandan
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Chandan c = new Chandan();
           
        }
    }
}
