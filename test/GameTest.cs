using System;
using System.Threading;
using Xunit;

namespace test
{
    public class GameTest
    {
        [Fact]
        public void IsNotYetTrueIfNotCheated()
        {
            // Arrange
            int random = new Random().Next(3, 10) * 1000;
            int go = Environment.TickCount + random;
            bool isNotCheating;

            // Act
            try
            {
                reaktionsspelet.Game.NotYet(go);
                isNotCheating = true;   
            }
            catch  
            {
                isNotCheating = false;   
            }

            // Assert
            Assert.True(isNotCheating);
        }
    }
}
