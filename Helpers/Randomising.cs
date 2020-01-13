using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class Randomising
    {
        private readonly dynamic Seed;
        //private static object random;
        public Randomising(dynamic seed)
        {
            Seed = seed;
        }
        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random(Seed);
            var randomNumber = random.Next(min, max);
            return randomNumber;
        }
    }
}
