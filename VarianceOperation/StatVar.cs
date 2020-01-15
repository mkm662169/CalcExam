using System;
using MeanOperation;
using Helpers;
using Square;
using SubtractionOperation;

namespace VarianceOperation
{
    public class StatVar
    {
        public static double Variance(dynamic values)
        {
            double mean = StatMean.Mean(values);
            double[] squDev = new double[Helpers.Arrays.Length(values)];
            int i = 0;

            foreach (int a in values)
            {
                squDev[i] = Square.Square.Squared(Subtraction.Difference(a, mean));
                i++;
            }
            double variance = StatMean.Mean(squDev);
            return variance;
        }
    }
}
