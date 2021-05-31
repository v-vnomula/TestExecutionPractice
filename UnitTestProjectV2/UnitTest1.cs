using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectV2
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("DataDriven")]
        //[DeploymentItem("TestData.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            int quantity = Convert.ToInt32(TestContext.DataRow[0].ToString());
            int price = Convert.ToInt32(TestContext.DataRow[1].ToString());
            int totalVal = Convert.ToInt32(TestContext.DataRow[2].ToString());
            Assert.AreEqual(quantity * price, totalVal);
        }

        [TestMethod]
        [TestCategory("DataDriven")]
        //[DeploymentItem("TestData.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestMethod2()
        {
            int quantity = Convert.ToInt32(TestContext.DataRow[0].ToString());
            int price = Convert.ToInt32(TestContext.DataRow[1].ToString());
            int totalVal = Convert.ToInt32(TestContext.DataRow[2].ToString());
            Assert.AreNotEqual(quantity + price, totalVal);
        }
    }
}
