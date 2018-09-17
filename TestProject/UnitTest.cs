using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMathDLL;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            // MyMath m = new myMathDLL();
            // Above doesn't work while class is static

            Assert.IsTrue(MyMath.Add(6, 7).Equals(13));
        }

        [TestMethod]
        public void AddTest2()
        {
            Assert.AreEqual(MyMath.Add(-5, -5), -10);
        }

        [TestMethod]
        public void AddMultiTest1()
        {
            List<int> testInts = new List<int>{1,2,3,4};
            Assert.AreEqual(MyMath.AddMulti(testInts), 10);
        }

        [TestMethod]
        public void AddMultiTest2()
        {
            List<int> testInts = new List<int> { -1, -2, -3, -4 };
            Assert.AreEqual(MyMath.AddMulti(testInts), -10);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.IsTrue(MyMath.Subtract(10, 5).Equals(5));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.IsTrue(MyMath.Multiply(10, 10).Equals(100));
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.IsTrue(MyMath.Divide(10, 5).Equals(2));
        }
    }
}
