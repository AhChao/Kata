using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata_TDD
{
    [TestClass]
    public class UnitTest1
    {
        TennisCounter counter = new TennisCounter();

        [TestMethod]
        public void Score_0_0_ShouldBe_Love_All()
        {
            Assert.AreEqual(counter.ScoreMsg(),"Love All");
        }

        [TestMethod]
        public void Score_1_0_ShouldBe_Fifteen_Love()
        {
            counter.FirstPlayerScore();
            Assert.AreEqual(counter.ScoreMsg(), "Fifteen_Love");
        }
    }
}
