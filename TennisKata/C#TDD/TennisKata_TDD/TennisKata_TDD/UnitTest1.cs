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
            Assert.AreEqual(ScoreMsg(),"Love All");
        }
    }
}
