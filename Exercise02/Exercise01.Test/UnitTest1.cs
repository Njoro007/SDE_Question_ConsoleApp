using System;
using Xunit;

namespace Exercise01.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestTens()
        {
            // Arrange
            // Setting up input data or prepare class instances
            var number = 62;


            // Act
            // Use the method to perform the test to get the results
            long j = new long();
            string result = j.Towards(number);

            // Assert
            // Return the boolean result to indicate if the test meets conditions
            Assert.Contains("Sixty Two", result);
        }

        [Fact]
        public void TestHundredThousand()
        {
            // Arrange
            // Setting up input data or prepare class instances
            var number = 125960;


            // Act
            // Use the method to perform the test to get the results
            long j = new long();
            string result = j.Towards(number);

            // Assert
            // Return the boolean result to indicate if the test meets conditions
            Assert.Contains("One Hundred  Twenty Five Thousand  Nine Hundred And Sixty", result);
        }

        [Fact]
        public void TestMillion()
        {
            // Arrange
            // Setting up input data or prepare class instances
            var number = 1259602;


            // Act
            // Use the method to perform the test to get the results
            long j = new long();
            string result = j.Towards(number);

            // Assert
            // Return the boolean result to indicate if the test meets conditions
            Assert.Contains("One Million  Two Hundred  Fifty Nine Thousand  Six Hundred And Two", result);
        }
    }
}
