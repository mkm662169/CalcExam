using System;
using Addition;
using Division;
using Helpers;

namespace MeanOperation
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Addition.Sum(values);
            var valueCount = Helpers.Arrays.Length(values);
            var mean = Division.Division.Quotient(sum, valueCount);
            return mean;
        }
    }
}
