using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestExample.csharp
{
    [TestFixture]
    public class exception
    {
        [Test]
        public void excpmethod()
        {
            try
            {
                int n1 = 0;
                int n2 = 100;
                int res = n2 / n1;
                Console.WriteLine("print n1"+ n1);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("divide by zero exception");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("index out of range");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("general exception");
            }
            finally
            {
                Console.WriteLine("finally completed");
            }
        }
    }
}
