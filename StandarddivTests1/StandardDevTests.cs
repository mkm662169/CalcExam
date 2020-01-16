using Microsoft.VisualStudio.TestTools.UnitTesting;
using Standarddev;
using System;
using System.Collections.Generic;
using System.Text;

namespace Standarddev.Tests
{
    
    public class StandardDevTests
    {
        private readonly double[] Arraya = { 1, 2, 3, 4, 5, 6 };
        [TestMethod()]
        public void SDTest()
        {
            Assert.AreEqual(1.78, StandardDeviation.SD(Arraya));
        }
    }
    
}