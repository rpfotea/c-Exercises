using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CloseFarT
    {
        [TestMethod]
        public void CloseFarTest()
        {
            Exercises closeF = new Exercises();

            Assert.AreEqual(true, closeF.CloseFar(1, 2, 12));
            Assert.AreEqual(false, closeF.CloseFar(1, 2,3));
            Assert.AreEqual(true, closeF.CloseFar(4, 1, 3));
        }
    }
}
