using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;
using Helpers;
using SquareRootOperation;
using MeanOperation;

namespace Calculator.Tests
{
    [TestClass()]
    public class StatsCalcTests
    {
        private readonly StatsCalc calculator = new StatsCalc();
        private readonly int min = 10;
        private readonly int max = 30;
        private readonly Randomising random = new Randomising(5);
        private readonly Randomising random1 = new Randomising(5);

        [TestMethod()]
        public void DifferenceTest()
        {
            dynamic c = calculator.Difference(random.GenerateRandomNumber(min, max), random1.GenerateRandomNumber(min, max));

            Assert.AreEqual(0, c);
            Assert.AreEqual(0, calculator.solution);
        }

        [TestMethod()]
        public void RootTest()
        {
            var c = SqRt.Root(random.GenerateRandomNumber(min, max));

            Assert.AreEqual(c, SqRt.Root(random.GenerateRandomNumber(min, max)));
        }

        [TestMethod()]
        public void MeanTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = StatMean.Mean(values);
            Assert.AreEqual(3, mean);
        }
    }
}
 