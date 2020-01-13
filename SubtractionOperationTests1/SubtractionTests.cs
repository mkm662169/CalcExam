﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubtractionOperation;
using System;
using System.Collections.Generic;
using System.Text;
using Helpers;
namespace SubtractionOperation.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int min = 10;
        private readonly int max = 30;
        private readonly Randomising random = new Randomising(5);
        private readonly Randomising random1 = new Randomising(5);
        /*private readonly Randomising random2 = new Randomising(5.5);
        private readonly Randomising random3 = new Randomising(5.5);*/


        [TestMethod()]
        public void DifferenceTest()
        {
            int c = Subtraction.Difference(random.GenerateRandomNumber(min, max), random1.GenerateRandomNumber(min, max));

            Assert.AreEqual(0, c);
        }

        /*[TestMethod()]
        public void DifferenceDoubleTest()
        {
            double c = Subtraction.Difference(random2.GenerateRandomNumber(min, max), random3.GenerateRandomNumber(min, max));
            Assert.AreEqual(0, c);
        }*/
    }
}