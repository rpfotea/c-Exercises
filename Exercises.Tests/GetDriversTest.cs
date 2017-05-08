using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class GetDriversTest
    {
        [TestMethod]
        public void GetDriversLicense()
        {
            //Arrange
            GetDrivers getDriver = new GetDrivers();

           
            //Act

            //Assert
            Assert.AreEqual(false, getDriver.GetDriversLicense(16, 20, false, true));
            Assert.AreEqual(false, getDriver.GetDriversLicense(16, 50, false, false));
            Assert.AreEqual(true, getDriver.GetDriversLicense(16, 50, true, true));
            Assert.AreEqual(false, getDriver.GetDriversLicense(16, 40, true, true));
            Assert.AreEqual(true, getDriver.GetDriversLicense(18, 0, true, true));
            Assert.AreEqual(false, getDriver.GetDriversLicense(15, 50, true, true));
        }
    }
}
