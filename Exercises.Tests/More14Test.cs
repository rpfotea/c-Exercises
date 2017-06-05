using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class More14T
    {
        [TestMethod]
        public void More14Test()
        {
            Exercises more14 = new Exercises();
            int[] set1 = new int[3] { 1, 4, 1 };
            int[] set2 = new int[4] { 1, 4, 1, 4 };
            int[] set3 = new int[2] { 1, 1};

            Assert.AreEqual(true, more14.More14(set1));
            Assert.AreEqual(false, more14.More14(set2));
            Assert.AreEqual(true, more14.More14(set3));

        }
    }
}
