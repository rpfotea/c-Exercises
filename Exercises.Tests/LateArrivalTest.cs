using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class LateArrivalTest
    {
        [TestMethod]
        public void LateArrivalT()
        {
            //arrange
            LateArr lateArrival = new LateArr();
            //act

            //assert
            
            Assert.AreEqual(true, lateArrival.LateArrival(20, 10, 60));
            Assert.AreEqual(true, lateArrival.LateArrival(20, 20, 60));
            Assert.AreEqual(false, lateArrival.LateArrival(40, 60, 50));
        }
    }
}
