using System;


using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculatorOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardDeviation
{
    [TestClass()]
    public class StandardDeviationTests
    {
        private readonly double[] Arraya = { 1, 2, 3, 4, 5, 6 };
        [TestMethod()]
        public void SDTest()
        {
            Assert.AreEqual(1.78, StandardDeviation.SD(Arraya));
        }

    }
}