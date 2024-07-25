using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cau1;

namespace Cau1_test
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\dataDriven.csv", "dataDriven#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            string inputStr = TestContext.DataRow[0].ToString();
            string inputSubStr = TestContext.DataRow[1].ToString();
            string expResult = TestContext.DataRow[2].ToString();

            FindString findStr = new FindString();
            object result = findStr.FindSubString(inputStr, inputSubStr);

            Assert.AreEqual(expResult, result.ToString());
        }
    }
}
