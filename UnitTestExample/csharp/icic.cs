using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestExample.csharp
{
    public class icic : bankdetails
    {
        public void credit()
        {
            Console.WriteLine("icic-credit");
        }
        public void debit()
        {
            Console.WriteLine("icic-debit");
        }
        public void transfer()
        {
            Console.WriteLine("icic-transfer");
        }
        public void icicgetbalance()
        {
            Console.WriteLine("icic-balance amount");
        }
    }
}
