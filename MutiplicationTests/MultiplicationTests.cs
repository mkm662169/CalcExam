using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mutiplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mutiplication.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly double c = 6.7;
        private readonly double d = 3.2;
       
        [TestMethod()]
        public void TimesTest()
        {
            Assert.AreEqual(18, Multiplication.Product(a, b));
        }

        [TestMethod()]
        public void TimesDoubleTest()
        {
            Assert.AreEqual(21.44, Multiplication.Product(c, d));
        }
    }
    
}