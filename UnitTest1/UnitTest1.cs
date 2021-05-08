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
    }
}
