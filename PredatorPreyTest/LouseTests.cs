using PredatorPrey.Contracts;
using Xunit;

namespace PredatorPrey.Tests
{
    public class LouseTests
    {
        private class LouseForTesting : Louse
        {
            public LouseForTesting(int age) : base(new Position(5, 5))
            {
                _age = age;
            }
        }

        [Fact]
        public void Louse_Newborn_CannotBreed()
        {
            var l = new Louse();
            Assert.Null(l.TryBreed());
        }

        [Fact]
        public void Louse_Age2_CanBreed()
        {
            var l = new LouseForTesting(age: 2);
            Assert.NotNull(l.TryBreed());
        }

        [Fact]
        public void Louse_Age1_CannotBreed()
        {
            var l = new LouseForTesting(age: 1);
            Assert.Null(l.TryBreed());
        }

        [Fact]
        public void Louse_Age3_CannotBreed()
        {
            var l = new LouseForTesting(age: 3);
            Assert.Null(l.TryBreed());
        }

        [Fact]
        public void Louse_Offspring_IsLouse()
        {
            var l = new LouseForTesting(age: 2);
            IAnimal offspring = l.TryBreed();
            Assert.IsType<Louse>(offspring);
        }
    }
}
