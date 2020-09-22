using System;
using Xunit;
using Fatbøde;

namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(55, 1)]
        [InlineData(60, 2)]
        [InlineData(61, 2)]
        [InlineData(100, 10)]
        [InlineData(10, 0)]
        public void CalculateKlipTest(int Speed, int Result)
        {
            Assert.Equal(FartMåler.BeregnKlip(Speed), Result);
        }
    }
}
