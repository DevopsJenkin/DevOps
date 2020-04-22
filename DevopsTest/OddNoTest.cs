using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StartDevOps;

namespace DevopsTest
{
    [TestClass]
    public class OddNoTest
    {
        [TestMethod]
        public void odd_no_test_return_false()
        {
            bool expected=new OddNo().IsOddNo(2);
            Assert.AreNotEqual(true, expected);
        }
    }
}
