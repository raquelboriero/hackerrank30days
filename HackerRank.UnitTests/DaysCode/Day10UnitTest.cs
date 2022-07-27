using HackerRank.DaysCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace HackerRank.UnitTests.DaysCode
{
    public class Day10UnitTest
    {
        [Fact]
        public void Run_MaximumOneInBinary_Success()
        {
            //Arrange
            var numberToBinary = 19;
            var console = new UnitTestConsoleWrapper(
                numberToBinary);

            //Act
            new Day10(console).Run();

            //Assert
            Assert.Equal("2\r\n", console.OutputMessages[0]);

        }

        [Theory]
        [InlineData(13, "2")]
        [InlineData(19, "2")]
        [InlineData(222, "4")]
        public void Run_Many_MaximumOneInBinary_Success(object numberToBinary, params string[] results)
        {
            //Arrange
            var console = new UnitTestConsoleWrapper(
                numberToBinary);

            //Act
            new Day10(console).Run();

            //Assert
            for (var i = 0; i < results.Length; i++)
            {
                Assert.Equal($"{results[i]}\r\n", console.OutputMessages[i]);
            }
        }

        [Theory]
        [InlineData(13, "2")]
        [InlineData(19, "2")]
        [InlineData(222, "4")]
        public void Run_Many_MaximumOneInBinary_Fail(object numberToBinary, params string[] results)
        {
            //Arrange
            var console = new UnitTestConsoleWrapper(
                numberToBinary);

            //Act
            new Day10(console).Run();

            //Assert
            for (var i = 0; i < results.Length; i++)
            {
                Assert.NotEqual($"{results[i]}\r\n", console.OutputMessages[i]);
            }
        }
    }
}
