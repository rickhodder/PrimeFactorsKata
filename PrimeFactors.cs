using System.Linq;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Generate(int number)
        {        
            foreach (var prime in Primes(number))
            {
                if (number % prime ==0)
                {
                    yield return prime;
                }
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