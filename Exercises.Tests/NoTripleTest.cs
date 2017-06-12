using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NoTripleT
    {
        [TestMethod]
        public void NoTrilpesTest()
        {
            Exercises noTriples = new Exercises();
            int[] set1 = new int[5] { 1, 1, 2, 2, 1 };
            int[] set2 = new int[6] { 1, 1, 2, 2, 2, 1 };
            int[] set3 = new int[7] { 1, 1, 1, 2, 2, 2, 1 };

            bool result1 = noTriples.NoTriples(set1);
            bool result2 = noTriples.NoTriples(set2);
            bool result3 = noTriples.NoTriples(set3);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);

        }
    }
}
