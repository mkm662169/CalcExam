using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarianceOperation;
using System;
using System.Collections.Generic;
using System.Text;

namespace VarianceOperation.Tests
{
    [TestClass()]
    public class StatVarTests
    {
        [TestMethod()]
        public void VarianceIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var variance = StatVar.Variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundToFive(variance));
        }

        [TestMethod()]
        public void VarianceTest2()
        {
            int[] values = { 17, 15, 23, 7, 9, 13 };
            var variance = StatVar.Variance(values);
            Assert.AreEqual(27.67, Helpers.Rounding.RoundToTwo(variance));
        }
    }
}