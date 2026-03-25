using System.Windows.Media;
using PredatorPrey.Contracts;

namespace PredatorPrey
{
    /// <summary>
    /// A louse (luis): the prey in this simulation.
    /// Color: GreenYellow. Max age: 6 rounds. Breeds every 2 rounds.
    /// </summary>
    public class Louse : Animal
    {
        private const int MaximumAge = 6;
        private const int BreedingInterval = 2;

        // Constructor for a louse at a random position.
        public Louse() : base(MaximumAge, Colors.GreenYellow)
        {
        }

        // Constructor for a newborn louse placed at a specific position (the parent's location).
        public Louse(Position position) : base(MaximumAge, Colors.GreenYellow, position)
        {
        }

        public override IAnimal TryBreed()
        {
            // TODO: Return a new Louse at the same Position if:
            //         - _age is greater than 0  (a newborn cannot immediately reproduce)
            //         - _age is divisible by BreedingInterval
            //       Otherwise return null.
            //
            // Tip: the modulo operator % gives the remainder of a division.
            throw new System.NotImplementedException();
        }
    }
}
