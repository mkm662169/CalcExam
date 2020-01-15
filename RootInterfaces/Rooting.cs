using System;
using System.Collections.Generic;
using System.Text;
using SquareRootOperation;

namespace RootInterfaces
{
    public class Rooting : IRoot
    {
        public dynamic solution;

        public dynamic Root(dynamic a)
        {
            solution = Root(a);
            return solution;
        }
    }
}
