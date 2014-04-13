using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerProject;

namespace EulerProjectTest
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Problem3 target = new Problem3();
            Assert.AreEqual(29, target.GetLargestPrime(13195));
        }
    }
}