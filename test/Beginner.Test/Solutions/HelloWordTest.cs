using Uri.Projects.Beginner.Solutions;
using Xunit;

namespace Beginner.Test.Solutions
{
    public class HelloWordTest
    {
        [Fact]
        public void HelloWordMustBeReturnSucess()
        {
            // Arrange
            var solution = new HelloWord();

            // Act
            var solutionResponse = solution.GetSolutionResponse();

            // Assert
            Assert.Equal("Hello World!", solutionResponse);
        }
    }
}
