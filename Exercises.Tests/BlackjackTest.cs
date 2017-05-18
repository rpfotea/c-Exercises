using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class BlackjackT
    {
        [TestMethod]
        public void BlackjackTest()
        {
            Exercises blackjack = new Exercises();

            Assert.AreEqual(0, blackjack.Blackjack(22, 24));
            Assert.AreEqual(21, blackjack.Blackjack(19, 21));
            Assert.AreEqual(21, blackjack.Blackjack(21, 19));
            Assert.AreEqual(19, blackjack.Blackjack(19, 22));
            Assert.AreEqual(19, blackjack.Blackjack(22, 19));
            Assert.AreEqual(19, blackjack.Blackjack(17, 19));
        }
    }
}
