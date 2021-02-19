using Uri.Projects.Beginner;
using Xunit;

namespace Beginner.Test
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
