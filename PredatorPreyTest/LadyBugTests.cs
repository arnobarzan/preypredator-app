using System.Collections.Generic;
using PredatorPrey.Contracts;
using Xunit;

namespace PredatorPrey.Tests
{
    public class LadyBugTests
    {
        private class LadyBugForTesting : LadyBug
        {
            public LadyBugForTesting(int age) : base(new Position(5, 5))
            {
                _age = age;
            }
        }

        // ── TryBreed ────────────────────────────────────────────────────

        [Fact]
        public void LadyBug_Newborn_CannotBreed()
        {
            var lb = new LadyBug();
            Assert.Null(lb.TryBreed());
        }

        [Fact]
        public void LadyBug_Age4_CanBreed()
        {
            var lb = new LadyBugForTesting(age: 4);
            Assert.NotNull(lb.TryBreed());
        }

        [Fact]
        public void LadyBug_Dead_CannotBreed()
        {
            var lb = new LadyBugForTesting(age: 4);
            lb.IsDead = true;
            Assert.Null(lb.TryBreed());
        }

        [Fact]
        public void LadyBug_Offspring_IsLadyBug()
        {
            var lb = new LadyBugForTesting(age: 4);
            IAnimal offspring = lb.TryBreed();
            Assert.IsType<LadyBug>(offspring);
        }

        // ── CanEat / Hunt ───────────────────────────────────────────────

        [Fact]
        public void LadyBug_CanEat_Louse()
        {
            IPredator lb = (IPredator)(new LadyBug());
            Assert.True(lb.CanEat(new Louse()));
        }

        [Fact]
        public void LadyBug_CannotEat_AnotherLadyBug()
        {
            IPredator lb = (IPredator)(new LadyBug());
            Assert.False(lb.CanEat(new LadyBug()));
        }

        [Fact]
        public void LadyBug_Hunt_KillsNearbyLouse()
        {
            var lb    = new LadyBug(new Position(5, 5));
            var louse = new Louse(new Position(5, 5));
            var world = new List<IAnimal> { lb, louse };
            ((IPredator)lb).Hunt(world);
            Assert.True(louse.IsDead);
        }

        [Fact]
        public void LadyBug_Hunt_DoesNotKillDistantLouse()
        {
            var lb    = new LadyBug(new Position(0, 0));
            var louse = new Louse(new Position(10, 10)); // distance ≈ 14.1
            var world = new List<IAnimal> { lb, louse };
            ((IPredator)lb).Hunt(world);
            Assert.False(louse.IsDead);
        }

        [Fact]
        public void LadyBug_StarvesAfter3RoundsWithoutFood()
        {
            var lb    = new LadyBug(new Position(0, 0));
            var world = new List<IAnimal> { lb }; // no prey
            var pred  = (IPredator)lb;
            pred.Hunt(world);
            pred.Hunt(world);
            pred.Hunt(world);
            Assert.True(lb.IsDead);
        }

        [Fact]
        public void LadyBug_EatingResetsStarvationCounter()
        {
            var lb    = new LadyBug(new Position(5, 5));
            var world = new List<IAnimal>();
            var pred  = (IPredator)lb;

            // Two rounds without food
            pred.Hunt(world);
            pred.Hunt(world);

            // Third round: nearby louse → ladybug eats and resets counter
            var louse = new Louse(new Position(5, 5));
            world.Add(louse);
            pred.Hunt(world);

            Assert.False(lb.IsDead);
        }
    }
}
