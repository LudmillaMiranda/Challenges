using System;

namespace AnimalsLegs
{
    public class Program
    {
        public static int animals(int chickens, int cows, int pigs)
        {
            int total = (chickens * 2) + (cows * 4) + (pigs * 4);
            return total; 
        }
    }
}
