using Uri.Projects.Beginner.Solutions;
using Xunit;

namespace Beginner.Test.Solutions
{
    public class HelloWordTest
    {
        [Fact]
        public void SolutionMustBeReturnSucess()
        {
            var solution = new HelloWordSolution().GetSolution();

            Assert.Equal("Hello World!", solution);
        }
    }
}
