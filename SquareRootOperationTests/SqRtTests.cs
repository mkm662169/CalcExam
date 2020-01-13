using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareRootOperation;
using System;
using System.Collections.Generic;
using System.Text;
using Helpers;

namespace SquareRootOperation.Tests
{
    [TestClass()]
    public class SqRtTests
    {
        private readonly int a = 10;
        private readonly int b = 30;
        private readonly Randomising rand = new Randomising(5);
       // private readonly Randomising rand1 = new Randomising(5);

        [TestMethod()]
        public void RootTest()
        {
            var c = SqRt.Root(rand.GenerateRandomNumber(a, b));
            Assert.AreEqual(c, SqRt.Root(rand.GenerateRandomNumber(a, b)));
        }
    }
}