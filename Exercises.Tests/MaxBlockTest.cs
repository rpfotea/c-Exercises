using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxBlockT
    {
        [TestMethod]
        public void MaxBlockTest()
        {
            Exercises maxBlock = new Exercises();

            Assert.AreEqual(0, maxBlock.MaxBlock(""));
            Assert.AreEqual(1, maxBlock.MaxBlock("a"));
            Assert.AreEqual(2, maxBlock.MaxBlock("hoopla"));
            Assert.AreEqual(3, maxBlock.MaxBlock("abbCCCddBBBxx"));
        }
    }
}
