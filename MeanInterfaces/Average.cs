using System;
using System.Collections.Generic;
using System.Text;
using MeanOperation;

namespace MeanInterfaces
{
    public class Average : IMean
    {
        public dynamic solution;

        public dynamic Mean(dynamic values)
        {
            solution = StatMean.Mean(values);
            return solution;
        }
    }
}
