using System.Collections.Generic;

namespace PredatorPrey.Contracts
{
    /// <summary>
    /// A predator is a special kind of animal that can hunt and eat other animals.
    /// Notice that IPredator extends IAnimal — so it inherits everything from IAnimal (and IDisplayable).
    /// </summary>
    public interface IPredator : IAnimal
    {
        // TODO: Add "bool CanEat(IAnimal animal)".
        //       Returns true when this predator is able to eat the given animal.
        //       Tip: use the "is" keyword to check the type at runtime.
        bool CanEat(IAnimal animal);

        // TODO: Add "void Hunt(IList<IAnimal> possibleVictims)".
        //       The predator scans the list for prey it can reach and eats them.
        //       Also tracks starvation: if the ladybug goes too many rounds without food, it dies.
        void Hunt(IList<IAnimal> possibleVictims);
    }
}
