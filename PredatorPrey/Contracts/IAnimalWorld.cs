using System.Collections.Generic;

namespace PredatorPrey.Contracts
{
    /// <summary>
    /// The simulation world. Manages all animals and drives the round-by-round logic.
    /// </summary>
    public interface IAnimalWorld
    {
        // TODO: Add a read-only property "AllAnimals" of type IList<IAnimal>.
        //       Returns the current list of all living animals in the world.


        // TODO: Add a read-only property "CurrentRoundNumber" of type int.


        // TODO: Add "void AddAnimal(IAnimal animal)".
        //       Registers the animal in the world AND displays it on the canvas.


        // TODO: Add "void ProcessRound()".
        //       Advances the simulation by one round:
        //         1. Every animal moves.
        //         2. Every animal tries to breed (add offspring to the world).
        //         3. Every predator hunts.
        //         4. Dead animals are removed from the world and the canvas.
        //
        //       Be careful: you cannot add or remove items from a list while
        //         iterating over it with foreach. Think about how to solve that.
    }
}
