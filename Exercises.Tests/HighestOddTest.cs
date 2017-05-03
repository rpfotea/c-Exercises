using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class HighestOddT
    {
        [TestMethod]
        public void HighestOddTest()
        {
            //arrange
            GoHighestOdd highestOdd = new GoHighestOdd();
            int[] nums1 = new int[0];
            int[] nums2 = new int[2] { 2, 10 };
            int[] nums3 = new int[3] { 3, 7, 8 };
            int[] nums4 = new int[4] { 0, 9, 8, 7 };
            //act

            //assert
            Assert.AreEqual(0, highestOdd.HighestOdd(nums1));
            Assert.AreEqual(0, highestOdd.HighestOdd(nums2));
            Assert.AreEqual(7, highestOdd.HighestOdd(nums3));
            Assert.AreEqual(9, highestOdd.HighestOdd(nums4));
        }
    }
}
