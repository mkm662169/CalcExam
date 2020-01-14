using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
using System;
using System.Collections.Generic;
using System.Text;

namespace Square.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 6;
        private readonly double c = 6.7;
        

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(36, Square.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(44.89, Square.Squared(c));
        }

    }
}