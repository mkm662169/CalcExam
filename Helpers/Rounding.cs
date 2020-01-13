using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class Rounding
    {
        public static dynamic RoundToTwo(dynamic a)
        {
            return Math.Round(a, 2);
        }
        public static dynamic RoundToFour(dynamic a)
        {
            return Math.Round(a, 4, MidpointRounding.ToEven);
        }
        public static dynamic RoundToFive(dynamic a)
        {
            return Math.Round(a, 5, MidpointRounding.ToEven);
        }
    }
}
