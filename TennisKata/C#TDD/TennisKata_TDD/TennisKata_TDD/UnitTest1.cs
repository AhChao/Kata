using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata_TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score_0_0_ShouldBe_Love_All()
        {
            TennisCounter counter = new TennisCounter();
            Assert.AreEqual(counter.ScoreMsg(),"Love All");
        }
    }
}
