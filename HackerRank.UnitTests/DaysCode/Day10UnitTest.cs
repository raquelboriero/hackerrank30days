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
            var expected = 2;
            var numberToBinary = 19;
            var console = new UnitTestConsoleWrapper(
                numberToBinary);

            //Act
            new Day10(console).Run();

            //Assert
            Assert.Equal(expected + "\r\n", console.OutputMessages[0]);

        }

        [Theory]
        [InlineData(13, 2)]
        [InlineData(19, 2)]
        [InlineData(222, 4)]
        public void Run_Many_MaximumOneInBinary_Success(int numberToBinary, int expected)
        {
            //Arrange
            //var expected = 2;
            //var numberToBinary = 19;
            var console = new UnitTestConsoleWrapper(
                numberToBinary);

            //Act
            new Day10(console).Run();

            //Assert
            Assert.Equal(expected + "\r\n", console.OutputMessages[0]);
        }

        [Theory]
        [InlineData("10011", 2)]
        [InlineData("1001100001001111", 4)]
        [InlineData("10011000010011110", 4)]
        [InlineData("010011000010011110", 4)]
        [InlineData("01001100001001111", 4)]
        public void ComputeOneSequences_Many_MaximumOneInBinary_Success(string binaryNumbers, int expected)
        {
            //Arrange

            //Act
            var result = new Day10().ComputeOneSequences(binaryNumbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(19, 3)]
        [InlineData(19, 1)]
        [InlineData(222, 5)]
        public void Run_Many_MaximumOneInBinary_Fail(int numberToBinary, int notExpected)
        {
            //Arrange
            //var expected = 2;
            //var numberToBinary = 19;
            var console = new UnitTestConsoleWrapper(
                numberToBinary);

            //Act
            new Day10(console).Run();

            //Assert
            Assert.NotEqual(notExpected + "\r\n", console.OutputMessages[0]);
        }
    }
}
