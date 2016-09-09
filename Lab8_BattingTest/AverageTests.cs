using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_Batting;

namespace Lab8_BattingTest
{
    [TestClass]
    public class AverageTests
    {
        [TestMethod]
        public void TestBattingPercentageis0WhenNoRuns()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;
            double battingAverage = Program.CalculateBattingAverage(battingSheet);
            Assert.AreEqual(0, battingAverage);

        }
        [TestMethod]
        public void TestBattingPercentageis60()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;
            double battingAverage = Program.CalculateBattingAverage(battingSheet);
            Assert.AreEqual(0.6, battingAverage);
        }
        [TestMethod]
        public void TestSluggingPercentageis60()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;
            double sluggingAverage = Program.CalculateSluggingAverage(battingSheet);
            Assert.AreEqual(1.4, sluggingAverage);
        }
    }
}
