using System.Collections.Generic;
using System.Windows.Controls;
using PredatorPrey.Contracts;

namespace PredatorPrey
{
    /// <summary>
    /// The simulation world. Holds all animals and runs each round.
    /// </summary>
    public class AnimalWorld : IAnimalWorld
    {
        private readonly Canvas _displayCanvas;

        public IList<IAnimal> AllAnimals { get; }
        public int CurrentRoundNumber { get; private set; }

        public AnimalWorld(Canvas displayCanvas)
        {
            _displayCanvas = displayCanvas;
            CurrentRoundNumber = 0;
            AllAnimals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            // TODO: Add the animal to AllAnimals AND call animal.DisplayOn(...) so it appears on screen.
            throw new System.NotImplementedException();
        }

        public void ProcessRound()
        {
            // TODO:
            //   1. Increment CurrentRoundNumber.
            //   2. Create two temporary lists: one for animals born this round, one for animals that die.
            //   3. Iterate over AllAnimals (don't modify the list inside the loop!):
            //        a. Call animal.Move()
            //        b. Call animal.TryBreed() — if not null, add offspring to the "born" list
            //           and call newborn.DisplayOn(_displayCanvas) right away.
            //        c. If the animal is an IPredator, cast it and call .Hunt(AllAnimals)
            //        d. If animal.IsDead, call animal.StopDisplaying() and add it to the "dead" list.
            //   4. After the loop:
            //        - Remove all dead animals from AllAnimals.
            //        - Add all newborns to AllAnimals.

            throw new System.NotImplementedException();
        }
    }
}
