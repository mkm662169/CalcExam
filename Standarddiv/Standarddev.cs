using System;
using StatisticalCalculatorOperations;

namespace Standarddev
{
    public class StandardDev : IStandarddev
    {
        public double result;

        public double SD(dynamic value)
        {
            return result = StandardDeviation.SD(value);
        }
    }
}