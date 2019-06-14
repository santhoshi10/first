using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestExample.csharp
{
    [TestFixture]
    public class bankdetailtest
    {
        [Test]
        public void bankdetailsmethod()
        {
            icic i = new icic();
            i.credit();
            i.debit();
            i.icicgetbalance();
            i.transfer();

            hdfc h = new hdfc();
            h.credit();
            h.debit();
            h.hdfcgetbalance();
            h.transfer();
        }
    }
}
