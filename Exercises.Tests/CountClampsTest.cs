using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CountClampsT
    {
        [TestMethod]
        public void CountClamsTest()
        {
            Exercises newClamps = new Exercises();
            int[] set1 = new int[6] { 1, 2, 2, 3, 4, 4 };
            int[] set2 = new int[5] { 1, 1, 2, 1, 1 };
            int[] set3 = new int[5] { 1, 1, 1, 1, 1 };

            Assert.AreEqual(2, newClamps.CountClumps(set1));
            Assert.AreEqual(2, newClamps.CountClumps(set2));
            Assert.AreEqual(1, newClamps.CountClumps(set3));
        }
    }
}
