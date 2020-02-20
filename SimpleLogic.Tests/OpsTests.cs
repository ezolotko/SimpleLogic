using Xunit;

namespace SimpleLogic.Tests
{
    public class OpsTests
    {
        [Fact]
        public void Nand()
        {
            Assert.False(Ops.Nand(1, 1));
            Assert.True(Ops.Nand(0, 0));
            Assert.True(Ops.Nand(1, 0));
            Assert.True(Ops.Nand(0, 1));
        }

        [Fact]
        public void Not()
        {
            Assert.True(Ops.Not(0));
            Assert.False(Ops.Not(1));
        }

        [Fact]
        public void And()
        {
            Assert.True(Ops.And(1, 1));
            Assert.False(Ops.And(0, 0));
            Assert.False(Ops.And(1, 0));
            Assert.False(Ops.And(0, 1));
        }

        [Fact]
        public void Or()
        {
            Assert.True(Ops.Or(1, 1));
            Assert.False(Ops.Or(0, 0));
            Assert.True(Ops.Or(1, 0));
            Assert.True(Ops.Or(0, 1));
        }

        [Fact]
        public void Xor()
        {
            Assert.False(Ops.Xor(1, 1));
            Assert.False(Ops.Xor(0, 0));
            Assert.True(Ops.Xor(1, 0));
            Assert.True(Ops.Xor(0, 1));
        }
    }
}