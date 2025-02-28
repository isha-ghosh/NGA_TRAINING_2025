using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomMathOperation
{
    [TestClass]
    public class BasicMathTest

    {
        BasicMath bm = new BasicMath();
        [TestMethod]
        public void Test_Add()
        {
            int r = bm.Add(9, 8);
            Assert.AreEqual(17, r);
        }
        [TestMethod]
        public void Test_Subtract()
        {
            int result = bm.Subtract(4, 5);

            // here we are checking wether the expected output and the actual output are same or not
            Assert.AreEqual(-1, result);


        }

        [TestMethod]
        public void Test_Multiply()
        {
            int result = bm.Multiply(4, 5);

            // here we are checking wether the expected output and the actual output are same or not
            Assert.AreEqual(20, result);


        }

        [TestMethod]
        public void Test_Division()
        {
            int result = bm.Divide(4, 5);

            // here we are checking wether the expected output and the actual output are same or not
            Assert.AreEqual(0, result);


        }
    }
}
