using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void Generate_30HasFactors2_3_5()
        {
            var factors = PrimeFactors.Generate(30).ToList();
            Assert.True(factors.Single(f=>f==2)==2 &&
                        factors.Single(f=>f==3)==3 &&
                        factors.Single(f=>f==5)==5);
        }

        [Fact]
        public void Generate_6HasFactors2_3()
        {
            var factors = PrimeFactors.Generate(6).ToList();
            Assert.True(factors.Single(f=>f==2)==2 &&
                        factors.Single(f=>f==3)==3);
        }

        [Fact]
        public void Generate_42HasFactors2_3_7()
        {
            var factors = PrimeFactors.Generate(42).ToList();
            Assert.True(factors.Single(f=>f==2)==2 &&
                        factors.Single(f=>f==3)==3 && 
                        factors.Single(f=>f==7)==7);
        }

        [Fact]
        public void Generate_TwoHasNoFactors()
        {
            var factors = PrimeFactors.Generate(2);
            Assert.Empty(factors);
        }


        [Fact]
        public void Generate_OneHasNoFactors()
        {
            var factors = PrimeFactors.Generate(1);
            Assert.Empty(factors);
        }
    }
}
