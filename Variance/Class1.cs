
using System;

using System.Collections.Generic;

using System.Text;

using Helpers;

using operations;

using StatOperations;



namespace StatOperations

{

    public class StatVariance

    {

        public static double Variance(dynamic values)

        {

            double mean = StatMean.Mean(values);

            double[] squaredDeviation = new double[Helpers.Array.Length(values)];

            int i = 0;



            foreach (int a in values)

            {

                squaredDeviation[i] = Square.Squared(Subtraction.Minus(a, mean));

                i++;

            }

            double variance = StatMean.Mean(squaredDeviation);

            return variance;

        }

    }

}