using PredatorPrey.Contracts;
using Xunit;

namespace PredatorPrey.Tests
{
    public class InterfaceTests
    {
        [Fact]
        public void Louse_ImplementsIAnimal()
        {
            Assert.IsAssignableFrom<IAnimal>(new Louse());
        }

        [Fact]
        public void LadyBug_ImplementsIAnimal()
        {
            Assert.IsAssignableFrom<IAnimal>(new LadyBug());
        }

        [Fact]
        public void LadyBug_ImplementsIPredator()
        {
            Assert.IsAssignableFrom<IPredator>(new LadyBug());
        }

        [Fact]
        public void Louse_DoesNotImplementIPredator()
        {
            Assert.False(new Louse() is IPredator);
        }

        [Fact]
        public void Louse_ImplementsIDisplayable()
        {
            Assert.IsAssignableFrom<IDisplayable>(new Louse());
        }
    }
}
