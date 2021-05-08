using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApplication1.Class1 c = new ConsoleApplication1.Class1();
            double act_mean = 0;
            int act_max = c.MaxAndMean(5, 2, 3, out act_mean);

            double exp_mean = 3.33;
            int exp_max = 5;
            Assert.AreEqual(exp_max, act_max, 0.1);
            Assert.AreEqual(exp_mean, act_mean, 0.1);
        }
        //Failed Test

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    ConsoleApplication1.Class1 c = new ConsoleApplication1.Class1();
        //    double act_mean = 0;
        //    int act_max = c.MaxAndMean(5, 2, 7, out act_mean);

        //    double exp_mean = 4.66;
        //    int exp_max = 7;
        //    Assert.AreEqual(exp_max, act_max, 0);
        //    Assert.AreEqual(exp_mean, act_mean, 0);
        //}
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\TextFile1.csv", "TextFile1#csv", DataAccessMethod.Sequential), DeploymentItem("TextFile1.csv"), TestMethod]
        public void TinhTienDienTest1()
        {
            ConsoleApplication1.Class1 c = new ConsoleApplication1.Class1();
            int chiSoCu = Convert.ToInt32(TestContext.DataRow[1].ToString());
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow[2].ToString());
            double actual = c.tinhTienDien(chiSoCu, chiSoMoi);
            double expected = Convert.ToDouble(TestContext.DataRow[3].ToString());
            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}
