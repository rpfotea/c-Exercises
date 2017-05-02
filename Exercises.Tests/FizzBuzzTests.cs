using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GoFizz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act

            //Assert
            Assert.AreEqual("1", fizzBuzz.GoFizz(1));
            Assert.AreEqual("Buzz", fizzBuzz.GoFizz(10));
            Assert.AreEqual("Fizz", fizzBuzz.GoFizz(3));
            Assert.AreEqual("Buzz", fizzBuzz.GoFizz(5));
            Assert.AreEqual("FizzBuzz", fizzBuzz.GoFizz(15));
            Assert.AreEqual("FizzBuzz", fizzBuzz.GoFizz(30));
        }
    }
}
