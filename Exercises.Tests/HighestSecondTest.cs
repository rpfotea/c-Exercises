using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class HighestSecondT
    {
        [TestMethod]
        public void HighestSecondTerst()
        {
            //arrange
            GoSecondHighest secondHigh = new GoSecondHighest();
            int[] nums1 = new int[0];
            int[] nums2 = new int[1] { 3 };
            int[] nums3 = new int[3] {1, 3, 5 };
            int[] nums4 = new int[3] { 1, 3, 3 };
            int[] nums5 = new int[6] { 1, 4, 6, 8, 23, 13 };
            int[] nums6 = new int[7] { 1, -2, 6, 14, 23, -13, 13 };
            //act

            //assert
            Assert.AreEqual(0, secondHigh.SecondHighest(nums1));
            Assert.AreEqual(3, secondHigh.SecondHighest(nums2));
            Assert.AreEqual(3, secondHigh.SecondHighest(nums3));
            Assert.AreEqual(3, secondHigh.SecondHighest(nums4));
            Assert.AreEqual(13, secondHigh.SecondHighest(nums5));
            Assert.AreEqual(14, secondHigh.SecondHighest(nums6));
        }
    }
}
