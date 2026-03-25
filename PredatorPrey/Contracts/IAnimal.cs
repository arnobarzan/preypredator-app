namespace PredatorPrey.Contracts
{
    /// <summary>
    /// Represents any animal in the simulation world.
    /// An IAnimal is also IDisplayable — it must be able to show itself on a canvas.
    /// </summary>
    public interface IAnimal : IDisplayable
    {
        // TODO: Add a read-only property "Position" of type Position.
        //       Position represents the animal's (X, Y) cell in a 16×16 grid.


        // TODO: Add a read-write property "IsDead" of type bool.
        //       This is set to true when the animal should be removed from the world.


        // TODO: Add a method "Move()" that moves the animal one step in a random direction
        //       and ages it by one round.


        // TODO: Add a method "TryBreed()" that returns a new IAnimal if the animal
        //       successfully reproduces this round, or null if it doesn't.
    }
}
