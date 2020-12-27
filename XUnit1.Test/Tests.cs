using System;
using Xunit;

namespace XUnit1.Test
{
    //https://stackoverflow.com/questions/54770830/unable-to-find-testhost-dll-please-publish-your-test-project-and-retry
    
    //https://github.com/xunit/xunit/issues/1950
    //run dotnet  test in sln (or project folder) et voila
    public class Tests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
