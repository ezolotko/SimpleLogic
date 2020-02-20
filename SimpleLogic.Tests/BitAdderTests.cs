using Xunit;

namespace SimpleLogic.Tests
{
    public class BitAdderTests
    {
        [Fact]
        public void CarryOut()
        {
            Assert.False(BitAdder.CarryOut(0, 0, 0));
            Assert.False(BitAdder.CarryOut(0, 0, 1));
            Assert.True(BitAdder.CarryOut(0, 1, 1));
            Assert.False(BitAdder.CarryOut(0, 1, 0));
            Assert.True(BitAdder.CarryOut(1, 1, 0));
            Assert.True(BitAdder.CarryOut(1, 1, 1));
            Assert.True(BitAdder.CarryOut(1, 0, 1));
            Assert.False(BitAdder.CarryOut(1, 0, 0));
        }

        [Fact]
        public void Sum()
        {
            Assert.False(BitAdder.Sum(0, 0, 0));
            Assert.True(BitAdder.Sum(0, 0, 1));
            Assert.False(BitAdder.Sum(0, 1, 1));
            Assert.True(BitAdder.Sum(0, 1, 0));
            Assert.False(BitAdder.Sum(1, 1, 0));
            Assert.True(BitAdder.Sum(1, 1, 1));
            Assert.False(BitAdder.Sum(1, 0, 1));
            Assert.True(BitAdder.Sum(1, 0, 0));
        }
    }
}