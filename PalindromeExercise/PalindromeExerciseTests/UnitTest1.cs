using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("blow", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            bool actual = test.IsAPalidrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
