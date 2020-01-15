using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IStatsCalc
    {
        dynamic Difference(dynamic a, dynamic b);

        dynamic Root(dynamic a);

        dynamic Mean(dynamic values);
    }
}
