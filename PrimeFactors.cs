using System.Linq;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Generate(int number)
        {
            foreach (var primeFactor in Primes(number).Where(p=>number % p ==0))
            {
                yield return primeFactor;
            }               
        }

        public static IEnumerable<int> Primes(int number)
        {
            for (int test = 2; test < number; test++)
            {
                if (number % test ==0)
                {
                    yield return test;
                }
            }
        }   
    }
}