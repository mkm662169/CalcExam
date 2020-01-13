using System;

namespace SubtractionOperation
{
    public class Subtraction
    {
        public static int Difference(int a, int b)
        {
            return a - b;
        }
        public static double Difference(double a, double b)
        {
            return a - b;
        }
        public static int Difference(int[] numbers)
        {
            int c = 0;

            foreach(int a in numbers)
            {
                c = Difference(c, a);
            }
            return c;
        }
        public static double Difference(double[] numbers)
        {
            double c = 0.0;

            foreach(double a in numbers)
            {
                c = Difference(c, a);
            }
            return c;

        }

    }
}
