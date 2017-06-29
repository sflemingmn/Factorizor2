using System.Collections.Generic;

namespace Factorizor3.BLL
{
    public class FactorFinder
    {
        public static int[] FactFinder(int num)
        {
            var allFactors = new List<int>();

            for (var i = 1; i <= num; i++)
                if (num % i == 0)
                    allFactors.Add(i);
            return allFactors.ToArray();
        }
    }
}