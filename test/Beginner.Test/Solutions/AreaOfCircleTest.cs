using System;
using System.IO;
using System.Text;
using Uri.Projects.Beginner.Solutions;
using Xunit;

namespace Beginner.Test.Solutions
{
    public class AreaOfCircleTest
    {
        [Theory]
        [InlineData("2,00", "A=12.5664")]
        [InlineData("100,64", "A=31819.3103")]
        [InlineData("150,00", "A=70685.7750")]
        public void AreaOfCircleMustBeReturnSucess(string radius, string expectedResponse)
        {
            // Arrange
            var solution = new AreaOfCircle();

            var inputText = new StringBuilder(radius);

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
