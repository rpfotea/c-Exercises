using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class ArrayIntersectionT
    {
        [TestMethod]
        public void ArrayIntersectiontest()
        {
            //arrange
            Exercises newIntersection = new Exercises();
            
            int[] a1 = new int[3]{ 1, 3, 5 };
            int[] b1 = new int[3]{ 1, 5, 7, };
            int[] r1 = new int[2] { 1, 5 };
                        
            int[] a2 = new int[1] { 1 };
            int[] b2 = new int[3] { 1, 5, 7, };
            int[] r2 = new int[1] { 1 };

            int[] a3 = new int[0] { };
            int[] b3 = new int[0] { };
            int[] r3 = new int[0] { };
            //ArrayIntersection([1, 1, 1], [1, 5, 7]) → [1]
            int[] a4 = new int[3] { 1, 1, 1 };
            int[] b4 = new int[3] { 1, 5, 7, };
            int[] r4 = new int[1] { 1};
            //act

            //assert
            CollectionAssert.AreEqual(r1, newIntersection.ArrayIntersection(a1, b1));
            CollectionAssert.AreEqual(r2, newIntersection.ArrayIntersection(a2, b2));
            CollectionAssert.AreEqual(r3, newIntersection.ArrayIntersection(a3, b3));
            CollectionAssert.AreEqual(r4, newIntersection.ArrayIntersection(a4, b4));
        }
    }
}
