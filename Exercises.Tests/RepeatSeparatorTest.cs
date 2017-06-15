using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class RepeatSeparatorT
    {
        [TestMethod]
        public void RepeatSeparatorTest()
        {
            Exercises repeatSep = new Exercises();

            string expect1 = "WordXWordXWord";
            string expect2 = "ThisAndThis";
            string expect3 = "This";

            Assert.AreEqual(expect1, repeatSep.RepeatSeparator("Word", "X", 3));
            Assert.AreEqual(expect2, repeatSep.RepeatSeparator("This", "And", 2));
            Assert.AreEqual(expect3, repeatSep.RepeatSeparator("This", "And", 1));
        }
    }
}
