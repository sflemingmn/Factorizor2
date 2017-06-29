using System;

namespace Factorizor3.BLL
{
    public class PrimeChecker
    {
        public static bool Prime(int[] factors)
        {
            if (factors.Length >= 3)
                return false;
            return true;
        }
    }
}