using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Has271T
    {
        [TestMethod]
        public void Has271Test()
        {
            Exercises has271 = new Exercises();
            int[] set1 = new int[4] {1,2,7,1 };
            int[] set2 = new int[5] { 3, 8, 2, 1, 9 };
            int[] set3 = new int[4] { 1, 2, 8, 1 };
            int[] set4 = new int[3] { -2, -7, -1 };

            Assert.AreEqual(true, has271.Has271(set1));
            Assert.AreEqual(true, has271.Has271(set2));
            Assert.AreEqual(false, has271.Has271(set3));
            Assert.AreEqual(true, has271.Has271(set4));
        }
    }
}
