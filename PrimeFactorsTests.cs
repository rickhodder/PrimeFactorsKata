using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void Generate_Test()
        {
            var factors = PrimeFactors.Generate(1);
            Assert.Equal(0,factors.Count());
        }
    }
}
