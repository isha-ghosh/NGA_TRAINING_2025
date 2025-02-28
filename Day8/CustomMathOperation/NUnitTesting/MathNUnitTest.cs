using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMathOperation;

namespace NUnitTesting
{
    [TestFixture]
   public class MathNUnitTest
    {
        BasicMath bm = new BasicMath();
        [Test]
        public void Test_Add()
        {
            int r = bm.Add(9, 8);
            int expected = 17;
            Assert.That(r.Equals(expected));
        }
       

    }
}
