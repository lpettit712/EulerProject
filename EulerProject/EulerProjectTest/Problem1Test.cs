using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerProject;

namespace EulerProjectTest
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Problem1 target = new Problem1();
            var list = new List<int> {3, 5};
            Assert.AreEqual(23, target.GetSumOfALlMultiples(10, list));
        }
    }
}
