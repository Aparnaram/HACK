using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WindowsFormsApplication1;
namespace UnitTest.Test
{
    [TestFixture]
    public class UnitTestClass
    {
        [TestCase]
        public void add(int a, int b)
        {
            Arithmetic arithmetic = new Arithmetic();
            int result = arithmetic.add(10, 40);
            Assert.AreEqual(60, result);
        }
    }
}
