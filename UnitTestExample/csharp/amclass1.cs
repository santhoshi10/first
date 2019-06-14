using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestExample.csharp
{
    public class amclass1
    {
        public string var1;
        internal void Method()
        {
            Console.WriteLine("internal method 1");
        }
        public static void main(string[] args)
        {
            amclass1 c1 = new amclass1();
            Console.WriteLine(c1.var1);
            c1.Method();
        }
    }
}
