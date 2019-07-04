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
            counter.FirstPlayerScore(1);
            Assert.AreEqual(counter.ScoreMsg(), "Fifteen Love");
        }

        [TestMethod]
        public void Score_2_0_ShouldBe_Thirty_Love()
        {
            counter.FirstPlayerScore(2);
            Assert.AreEqual(counter.ScoreMsg(), "Thirty Love");
        }

        [TestMethod]
        public void Score_3_0_ShouldBe_Forty_Love()
        {
            counter.FirstPlayerScore(3);
            Assert.AreEqual(counter.ScoreMsg(), "Forty Love");
        }
    }
}
