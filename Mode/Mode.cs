using System;
using System.Linq;

namespace Mode
{
    public class Mode
    {

        public static double Findmode(int[] x)
        {
            int high = x.OrderByDescending(n => n).First();
            int mode = x.GroupBy(i => i)  //Grouping same items
            .OrderByDescending(g => g.Count()) //now getting frequency of a value
            .Select(g => g.Key) //selecting key of the group
            .FirstOrDefault();   //Finally, taking the most frequent value

            return mode;
        }



    }
}

