using HackerRank.DaysCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace HackerRank.UnitTests.DaysCode
{
    public class Day5UnitTests
    {
        [Fact]
        public void Run_2_TabuadaResult_Success()
        {
            //Arrange
            var numberToCreateTabuada = 2;
            var console = new UnitTestConsoleWrapper(
                numberToCreateTabuada);

            //Act
            new Day5(console).Run();

            //Assert
            Assert.Equal("2 x 1 = 2\r\n", console.OutputMessages[0]);
            Assert.Equal("2 x 2 = 4\r\n", console.OutputMessages[1]);
            Assert.Equal("2 x 3 = 6\r\n", console.OutputMessages[2]);
            //Assert.NotEqual("2 x 2 = 6\r\n", console.OutputMessages[2]);
        }

        [Theory]
        [InlineData(2, "2 x 1 = 2", "2 x 2 = 4")]
        [InlineData(3, "3 x 1 = 3")]
        public void Run_Many_TabuadaResult_Success(object numberToCreateTabuada, params string[] results)
        {
            //Arrange
            var console = new UnitTestConsoleWrapper(
                numberToCreateTabuada);

            //Act
            new Day5(console).Run();

            //Assert
            for (var i = 0; i < results.Length; i++)
            {
                Assert.Equal($"{results[i]}\r\n", console.OutputMessages[i]);
            }
        }

        [Theory]
        [InlineData(2, "2 x 1 = 4")]
        [InlineData(3, "3 x 2 = 6")]
        public void Run_Many_TabuadaResult_Fail(object numberToCreateTabuada, params string[] results)
        {
            //Arrange
            var console = new UnitTestConsoleWrapper(
                numberToCreateTabuada);

            //Act
            new Day5(console).Run();

            //Assert
            for (var i = 0; i < results.Length; i++)
            {
                Assert.NotEqual($"{results[i]}\r\n", console.OutputMessages[i]);
            }
        }
    }
}
