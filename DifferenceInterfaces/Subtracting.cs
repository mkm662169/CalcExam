using System;
using SubtractionOperation;

namespace DifferenceInterfaces
{
    public class Subtracting : IDifferences
    {
        public dynamic solution;

        public dynamic Difference(dynamic a, dynamic b)
        {
            solution = Subtraction.Difference(a, b);
            return solution;
        }
    }
}
