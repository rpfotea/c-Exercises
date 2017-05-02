using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NeedsCheck
    {
        [TestMethod]
        public void NeedsCheckTest()
        {
            //arrange
            Needs_E_Check needC = new Needs_E_Check();
            //act

            //assert
            Assert.AreEqual(true, needC.NeedsECheck(2017, 2011));
            Assert.AreEqual(true, needC.NeedsECheck(2016, 2004));
            Assert.AreEqual(false, needC.NeedsECheck(2011, 2012));
            Assert.AreEqual(false, needC.NeedsECheck(2011, 1992));
        }
    }
}
