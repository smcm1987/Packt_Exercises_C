using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsTest
{
    public class FactorTests
    {
        [Fact]
        public void PrimeBoolTest()
        {
            bool primeBool = true;
            int primeTest = 3;
            Assert.Equal(primeBool, PrimeFactors.IsPrime(primeTest));

        }
        [Fact]
        public void NotPrimeBoolTest()
        {
            bool primeBool = false;
            int primeTest = 4;
            Assert.Equal(primeBool, PrimeFactors.IsPrime(primeTest));

        }

        [Fact]
        public void ListPrimesTest()
        {
            PrimeFactors stringList = new PrimeFactors();
            string? primer = stringList.numberFactors(50);
            string? primeTest = "2 x 5 x 5";
            Assert.Equal(primeTest, primer);
        }
    }
}