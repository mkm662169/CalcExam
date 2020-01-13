using Microsoft.VisualStudio.TestTools.UnitTesting;
using Division;
using System;
using System.Collections.Generic;
using System.Text;

namespace Division.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 20;
        private readonly int b = 10;
        private readonly double c = 20.3;
        private readonly double d = 10.2;
        private readonly int e = 0;

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(2, Division.Quotient(a, b));
        }

        [TestMethod()]
        public void QuotientDoulbleTest()
        {
            Assert.AreEqual(1.9901960784313728, Division.Quotient(c, d));
        }

        [TestMethod()]
        public void QuotientintQuotientZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(a, e));
        }
    }
}

