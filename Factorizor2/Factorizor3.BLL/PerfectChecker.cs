using System;

namespace Factorizor3.BLL
{
    public class PerfectChecker
    {
        public static bool Perfect(int[] factors, int num)
        {
            bool perfect;
            var count = 0;

            for (var i = 1; i < num; i++)
                if (num % i == 0)
                    count = count + i;
            if (count == num)
                perfect = true;
            else
                perfect = false;
            return perfect;
        }
    }
}