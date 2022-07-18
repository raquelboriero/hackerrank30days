using HackerRank.DaysCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRank.UnitTests.DaysCode
{
    public class Day9UnitTest
    {
        [Fact]
        public void Run_2_FactorialResult_Success()
        {
            //Arrange
            var numberToFactorial = 2;
            var console = new UnitTestConsoleWrapper(
                numberToFactorial);

            //Act
            new Day9(console).Run();

            //Assert
            Assert.Equal("2 x 1 = 2\r\n", console.OutputMessages[0]);

        }

        [Theory]
        [InlineData(2, "2 x (2 - 1) = 2")]
        [InlineData(3, "3 x (3 - 1) = 6")]
        [InlineData(5, "5 x (5 - 1) = 20")]
        public void Run_Many_FactorialResul_Success(object numberToFactorial, params string[] results)
        {
            //Arrange
            var console = new UnitTestConsoleWrapper(
                numberToFactorial);

            //Act
            new Day9(console).Run();

            //Assert
            for (var i = 0; i < results.Length; i++)
            {
                Assert.Equal($"{results[i]}\r\n", console.OutputMessages[i]);
            }
        }

        [Theory]
        [InlineData(2, "2 x 1 = 4")]
        [InlineData(3, "3 x 2 = 6")]
        public void Run_Many_FactorialResul_Fail(object numberToFactorial, params string[] results)
        {
            //Arrange
            var console = new UnitTestConsoleWrapper(
                numberToFactorial);

            //Act
            new Day9(console).Run();

            //Assert
            for (var i = 0; i < results.Length; i++)
            {
                Assert.NotEqual($"{results[i]}\r\n", console.OutputMessages[i]);
            }
        }



    }
}
