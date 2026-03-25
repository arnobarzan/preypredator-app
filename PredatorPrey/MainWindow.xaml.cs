using System;
using System.Windows;
using PredatorPrey.Contracts;

namespace PredatorPrey
{
    public partial class MainWindow : Window
    {
        // TODO: Declare a private field "_insectWorld" of type IAnimalWorld.
        //       Note the type: IAnimalWorld, not AnimalWorld.
        //       This is polymorphism at work — we depend on the interface, not the concrete class.
        private IAnimalWorld _insectWorld;

        public MainWindow()
        {
            InitializeComponent();
            /* // TODO: remove comment
            InitializeWorld();
            DisplayStatistics();
            */
        }

        private void InitializeWorld()
        {
            // TODO:
            //   1. Create a new AnimalWorld, passing the "environment" canvas (defined in XAML).
            //   2. Add 100 Louse instances to the world.
            //   3. Add 10 LadyBug instances to the world.
            throw new NotImplementedException();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Call ProcessRound() on _insectWorld, then update the statistics labels.
            throw new NotImplementedException();
        }

        private void DisplayStatistics()
        {
            // TODO: Update the three labels:
            //   - numberOfRoundsLabel  → _insectWorld.CurrentRoundNumber
            //   - numberOfLadyBugsLabel → count of LadyBug instances in AllAnimals
            //   - numberOfLousesLabel   → count of Louse instances in AllAnimals
            //
            // Tip: loop over _insectWorld.AllAnimals and use "is" to check the type.
            throw new NotImplementedException();
        }
    }
}
