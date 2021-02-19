using System;
using System.IO;
using System.Text;
using Uri.Projects.Beginner.Solutions;
using Xunit;

namespace Beginner.Test.Solutions
{
    public class ExtremelyBasicTest
    {
        [Theory]
        [InlineData("10","9","X = 19")]
        [InlineData("-10", "4", "X = -6")]
        [InlineData("15", "-7", "X = 8")]
        public void ExtremelyBasicMustBeReturnSucess(string firstValue, string secondValue, string expectedResponse)
        {
            // Arrange
            var solution = new ExtremelyBasic();

            var inputText = new StringBuilder();
            inputText.AppendLine(firstValue);
            inputText.AppendLine(secondValue);

            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(inputText.ToString());
            Console.SetIn(input);

            // Act
            var solutionResponse = solution.GetSolutionResponse();

            // Assert
            Assert.Equal(expectedResponse, solutionResponse);
        }
    }
}
