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

        [TestMethod]
        public void Score_4_0_ShouldBe_Player1_Won()
        {
            counter.FirstPlayerScore(4);
            Assert.AreEqual(counter.ScoreMsg(), "Player1 Won");
        }

        [TestMethod]
        public void Score_0_1_ShouldBe_Love_Fifteen()
        {
            counter.SecondPlayerScore(1);
            Assert.AreEqual(counter.ScoreMsg(), "Love Fifteen");
        }

        [TestMethod]
        public void Score_1_1_ShouldBe_Fifteen_All ()
        {
            counter.FirstPlayerScore(1);
            counter.SecondPlayerScore(1);
            Assert.AreEqual(counter.ScoreMsg(), "Fifteen All");
        }

        [TestMethod]
        public void Score_3_3_ShouldBe_Deuce()
        {
            counter.FirstPlayerScore(3);
            counter.SecondPlayerScore(3);
            Assert.AreEqual(counter.ScoreMsg(), "Deuce");
        }

        [TestMethod]
        public void Score_4_4_ShouldBe_Deuce()
        {
            counter.FirstPlayerScore(4);
            counter.SecondPlayerScore(4);
            Assert.AreEqual(counter.ScoreMsg(), "Deuce");
        }

        [TestMethod]
        public void Score_4_3_ShouldBe_Player1_Adv()
        {
            counter.FirstPlayerScore(4);
            counter.SecondPlayerScore(3);
            Assert.AreEqual(counter.ScoreMsg(), "Player1 Adv");
        }

        [TestMethod]
        public void Score_0_4_ShouldBe_Player2_Won()
        {
            counter.FirstPlayerScore(0);
            counter.SecondPlayerScore(4);
            Assert.AreEqual(counter.ScoreMsg(), "Player2 Won");
        }

        [TestMethod]
        public void Score_3_4_ShouldBe_Player2_Adv()
        {
            counter.FirstPlayerScore(3);
            counter.SecondPlayerScore(4);
            Assert.AreEqual(counter.ScoreMsg(), "Player2 Adv");
        }
    }
}
