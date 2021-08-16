using System;
using Xunit;
using Lab4_3PrimeNumbers;

namespace PrimeNumbers_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(11, true)]
        [InlineData(60, false)]
        [InlineData(73, true)]
        [InlineData(100, false)]
        public void TestIsPrimeNumber(int _num, bool _expected)
        {
            Assert.Equal(_expected, PrimeNumbers.IsPrimeNumber(_num));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 11)]
        [InlineData(21, 73)]
        [InlineData(42, 181)]
        [InlineData(204, 1249)]

        public void TestGetPrime(int _num, int _expected)
        {
            Assert.Equal(_expected, PrimeNumbers.GetPrime(_num));
        }
    }
}
