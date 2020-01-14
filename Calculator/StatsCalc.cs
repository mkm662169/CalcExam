using System;
using DifferenceInterfaces;
using MeanInterfaces;
using RootInterfaces;

namespace Calculator
{
    public class StatsCalc : IDifferences, IMean, IRoot
    {
        readonly Subtracting difference = new Subtracting();
        readonly Average average = new Average();
        readonly Rooting root = new Rooting();

        public dynamic solution;

        public dynamic Difference(dynamic a, dynamic b)
        {
            solution = SubtractionOperation.Subtraction.Difference(a, b);
            return solution;
        }
        public dynamic Root(dynamic a)
        {
            solution = SquareRootOperation.SqRt.Root(a);
            return solution;
        }
        public dynamic Mean(dynamic values)
        {
            solution = MeanOperation.StatMean.Mean(values);
            return solution;
        }
    }
}
