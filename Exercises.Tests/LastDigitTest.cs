using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class LastDigitT
    {
        [TestMethod]
        public void LastDigitTest()
        {
            //arrange
            Exercises lastDigit = new Exercises();
            //act

            //assert
            Assert.AreEqual(true, lastDigit.LastDigit(23, 19, 13));
            Assert.AreEqual(false, lastDigit.LastDigit(23, 19, 12));
            Assert.AreEqual(true, lastDigit.LastDigit(23, 19, 3));
        }
    }
}
