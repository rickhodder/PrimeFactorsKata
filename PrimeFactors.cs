using System.Linq;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Generate(int number)
        {
            foreach (var primeFactor in PrimesUnder(number)
                                        .Where(p => number % p == 0))
            {
                yield return primeFactor;
            }
        }

        public static IEnumerable<int> PrimesUnder(int number)
        {
            for (int test = 2; test < number; test++)
            {
                if (IsPrime(test))
                {
                    yield return test;
                }
            }
        }

        public static bool IsPrime(int number)
        {
            var isPrime=true;
            for (int test = 2; test < number; test++)
            {
                if(number % test==0)
                {
                    isPrime=false;
                    break;
                }
            }

            return isPrime;
        }
    }
}