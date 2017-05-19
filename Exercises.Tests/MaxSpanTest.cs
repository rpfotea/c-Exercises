using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxSpanT
    {
        [TestMethod]
        public void MaxSpanTest()
        {
            Exercises maxSpan = new Exercises();
            int[] nums1 = new int[0] { };
            int[] nums2 = new int[1] { 4 };
            int[] nums3 = new int[5] { 1, 2, 1, 1, 3 };
            int[] nums4 = new int[7] { 1, 4, 2, 1, 4, 1, 4 };
            int[] nums5 = new int[7] { 1, 4, 2, 1, 4, 4, 4 };
            int[] nums6 = new int[10] { 9, 6, 8, 1, 4, 3, 1, 4, 4, 3 };

            Assert.AreEqual(0, maxSpan.MaxSpan(nums1));
            Assert.AreEqual(1, maxSpan.MaxSpan(nums2));
            Assert.AreEqual(4, maxSpan.MaxSpan(nums3));
            Assert.AreEqual(6, maxSpan.MaxSpan(nums4));
            Assert.AreEqual(6, maxSpan.MaxSpan(nums5));
            Assert.AreEqual(5, maxSpan.MaxSpan(nums6));
        }
    }
}
