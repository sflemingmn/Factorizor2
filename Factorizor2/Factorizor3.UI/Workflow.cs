using Factorizor3.BLL;

namespace Factorizor3.UI
{
    internal class Workflow
    {
        public void StartFactoring()
        {
            var num = Input.GetNumberFromUser();                    // get # from user
            var factors = FactorFinder.FactFinder(num);             // get factor
            var prime = PrimeChecker.Prime(factors);                // is prime
            var perfect = PerfectChecker.Perfect(factors, num);     // is perfect
            Output.Results(num, factors, prime, perfect);           // send results to Output.cs
        }
    }
}