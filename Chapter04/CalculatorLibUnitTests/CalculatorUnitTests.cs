using CalculatorLib;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        //Unit testing calc class via arrange, act, assert method (see notes)
        [Fact]
        public void TestAdd2and2()
        {
            //arrange
            double a = 2; 
            double b = 2;
            double expected = 4;
            Calculator calc = new();

            //act
            double actual = calc.Add(a, b);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd2and3()
        {
            //arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new();

            //act
            double actual = calc.Add(a, b);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}