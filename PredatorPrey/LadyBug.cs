using System;
using System.Collections.Generic;
using System.Windows.Media;
using PredatorPrey.Contracts;

namespace PredatorPrey
{
    /// <summary>
    /// A ladybug (lieveheersbeestje): the predator in this simulation.
    /// Color: Red. Max age: 16 rounds. Breeds every 4 rounds.
    /// Must eat at least once every 3 rounds or it starves to death.
    /// </summary>
    public class LadyBug : Animal
    {
        private const int MaximumAge = 16;
        private const int BreedingInterval = 4;
        private const int MaxHuntDistance = 3;
        private const int StarvationLimit = 3;

        // TODO: Add a private field to track how many consecutive rounds this ladybug has not eaten.
        private int _roundsWithoutFood;

        public LadyBug() : base(MaximumAge, Colors.Red)
        {
        }

        public LadyBug(Position position) : base(MaximumAge, Colors.Red, position)
        {
            _roundsWithoutFood = 0;
        }

        public override IAnimal TryBreed()
        {
            // TODO: Same pattern as Louse but with BreedingInterval = 4.
            //       Extra condition: don't breed if already dead (IsDead == true).
            throw new NotImplementedException();
        }

        // ── IPredator ───────────────────────────────────────────────────────────

        public bool CanEat(IAnimal animal)
        {
            // TODO: A ladybug can only eat a Louse.
            //       Use the "is" keyword: animal is Louse
            throw new NotImplementedException();
        }

        public void Hunt(IList<IAnimal> possibleVictims)
        {
            // TODO:
            //   1. Increment _roundsWithoutFood.
            //   2. Loop over possibleVictims. For each one:
            //        - Check CanEat(victim)  AND  distance <= MaxHuntDistance.
            //        - If both true: eat the victim (set victim.IsDead = true, reset _roundsWithoutFood to 0).
            //   3. After the loop: if _roundsWithoutFood >= StarvationLimit, set IsDead = true.

            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the straight-line (Euclidean) distance between this ladybug and another animal.
        /// Formula: sqrt( (x2-x1)^2 + (y2-y1)^2 )
        /// </summary>
        private double CalculateDistanceTo(IAnimal other)
        {
            // TODO: Implement using Math.Pow(..., 2) and Math.Sqrt(...)
            throw new NotImplementedException();
        }
    }
}
