using PredatorPrey.Contracts;
using Xunit;

namespace PredatorPrey.Tests
{
    public class PositionTests
    {
        [Fact]
        public void Position_XAndY_SetByConstructor()
        {
            var p = new Position(5, 8);
            Assert.Equal(5, p.X);
            Assert.Equal(8, p.Y);
        }

        [Fact]
        public void Position_X_CannotGoBelowZero()
        {
            var p = new Position(0, 0);
            p.MoveLeft();
            Assert.Equal(0, p.X);
        }

        [Fact]
        public void Position_X_CannotGoAbove15()
        {
            var p = new Position(15, 0);
            p.MoveRight();
            Assert.Equal(15, p.X);
        }

        [Fact]
        public void Position_Y_CannotGoBelowZero()
        {
            var p = new Position(0, 0);
            p.MoveUp();
            Assert.Equal(0, p.Y);
        }

        [Fact]
        public void Position_Y_CannotGoAbove15()
        {
            var p = new Position(0, 15);
            p.MoveDown();
            Assert.Equal(15, p.Y);
        }

        [Fact]
        public void Position_MoveRight_IncreasesXByOne()
        {
            var p = new Position(5, 5);
            p.MoveRight();
            Assert.Equal(6, p.X);
        }

        [Fact]
        public void Position_MoveDown_IncreasesYByOne()
        {
            var p = new Position(5, 5);
            p.MoveDown();
            Assert.Equal(6, p.Y);
        }
    }
}
