using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cau2;

namespace cau2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPrime()
        {
            ClassCau2 classCau2 = new ClassCau2();
            Assert.AreEqual(false, classCau2.IsPrime(0));
            Assert.AreEqual(false, classCau2.IsPrime(1));
            Assert.AreEqual(true, classCau2.IsPrime(2));
            Assert.AreEqual(false, classCau2.IsPrime(4));
            Assert.AreEqual(true, classCau2.IsPrime(5));
            Assert.AreEqual(false, classCau2.IsPrime(9));
            Assert.AreEqual(true, classCau2.IsPrime(11));
            Assert.AreEqual(true, classCau2.IsPrime(10));
        }

        [TestMethod]
        public void TestSumOfDigits()
        {
            ClassCau2 classCau2 = new ClassCau2();
            Assert.AreEqual(1, classCau2.SumOfDigits(10));
            Assert.AreEqual(6, classCau2.SumOfDigits(123));
            Assert.AreEqual(0, classCau2.SumOfDigits(0));
        }
    }
}
