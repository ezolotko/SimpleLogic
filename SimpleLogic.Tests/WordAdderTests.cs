using Xunit;

using static SimpleLogic.WordConverter;

namespace SimpleLogic.Tests
{
    public class WordAdderTests
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 3, 13)]
        public void Add(int a, int b, int expectedSum)
        {
            Assert.Equal(expectedSum, FromWord(WordAdder.Add(ToWord(a), ToWord(b))));
        }
    }
}