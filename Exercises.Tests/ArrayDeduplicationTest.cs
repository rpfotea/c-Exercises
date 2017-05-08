using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class ArrayDeduplicationT
    {
        [TestMethod]
        public void ArrayDeduplicateTest()
        {
            //arrange
            Exercises newDedup = new Exercises();                     
            int[] nums1 = new int[6] { 1, 6, 4, 6, 23, 13 };
            int[] fin1 = new int[5] { 1, 6, 4, 23, 13 };
            int[] nums2 = new int[7] { 1, 1, 1, 14, 23, 13, 23 };
            int[] fin2 = new int[4] { 1, 14, 23, 13 };
            int[] nums3 = new int[0] { };
            int[] fin3 = new int[0] { };
            int[] nums4 = new int[4] { 1, 1, 1, 1 };
            int[] fin4 = new int[1] { 1 };
            //act

            //assert
            CollectionAssert.AreEqual(fin1, newDedup.ArrayDeduplication(nums1));
            CollectionAssert.AreEqual(fin2, newDedup.ArrayDeduplication(nums2));
            CollectionAssert.AreEqual(fin3, newDedup.ArrayDeduplication(nums3));
            CollectionAssert.AreEqual(fin4, newDedup.ArrayDeduplication(nums4));
        }
    }
}
