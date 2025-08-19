
using JenkinsDemo;

namespace JenkinsDemoUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            Assert.Equal(5, Program.Add(2, 3));
        }
    }
}
