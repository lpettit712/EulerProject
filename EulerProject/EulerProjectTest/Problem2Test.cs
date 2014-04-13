using EulerProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerProjectTest
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var target = new Problem2();
            Assert.AreEqual(44, target.GetTotalSum(89));
            //Assert.AreEqual(44, target.FibbonacciSumEven(89));
        }
    }
}