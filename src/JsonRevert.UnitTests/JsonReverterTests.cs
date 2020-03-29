using System;
using JsonRevert.WebAPI.BusinessLogic;
using Xunit;

namespace JsonRevert.UnitTests
{
    public class JsonReverterTests
    {
        [Theory]
        [InlineData(@"{A:1, B:1, C:1, D:1, E:1}", @"{
  E: 1,
  D: 1,
  C: 1,
  B: 1,
  A: 1
}")]
        public void ShouldRevertInputJson(string input, string expected)
        {
            // Arrange
            var sut = new JsonReverter();
            
            // Act
            var actual = sut.RevertJson(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}