using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class OneTwoT
    {
        [TestMethod]
        public void OneTwoTest()
        {
            Exercises oneTwo = new Exercises();
            string input1 = "abc";
            string input2 = "tca";
            string input3 = "tcagdo";

            string output1 = oneTwo.OneTwo(input1);
            string output2 = oneTwo.OneTwo(input2);
            string output3 = oneTwo.OneTwo(input3);

            Assert.AreEqual("bca", output1);
            Assert.AreEqual("cat", output2);
            Assert.AreEqual("catdog", output3);

        }
    }
}
