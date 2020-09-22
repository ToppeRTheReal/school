using System;
using Xunit;
using Trekant;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestOmkreds()
        {
            // Arrange
            var trekant = new Trekant.Trekant();
            trekant.Init(6, 6, 10);

            // Act
            double omkreds = trekant.Omkreds();
            
            // Assert
            Assert.True(omkreds == 22);
        }
    }
}
