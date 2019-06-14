using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestExample.csharp
{
    public class hdfc : bankdetails
    {
        public void credit()
        {
            Console.WriteLine("HDFC credit");
        }
        public void debit()
        {
            Console.WriteLine("HDFC-debit");
        }
        public void transfer()
        {
            Console.WriteLine("HDFC-transfer");
        }
        public void hdfcgetbalance()
        {
            Console.WriteLine("HDFC-balance amount");
        }
    }
}
