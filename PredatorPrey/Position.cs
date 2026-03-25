namespace PredatorPrey
{
    /// <summary>
    /// Represents a cell on the 16×16 simulation grid.
    /// Both X and Y must stay within [0, 15] at all times.
    /// </summary>
    public class Position
    {
        private const int Max = 15;
        private const int Min = 0;

        // TODO: Add a private backing field for X and implement the public property.
        //       The setter must clamp the value: below 0 becomes 0, above 15 becomes 15.
        //       Make the setter private so only this class can change X.
        public int X { get; private set; }

        // TODO: Same for Y.
        public int Y { get; private set; }

        public Position(int x, int y)
        {
            // TODO: Assign x to X and y to Y.
            //       Because the setters clamp the values, you get boundary checking for free!
        }

        // TODO: Implement MoveUp()   → Y decreases by 1 (clamped automatically by the setter)
        public void MoveUp()
        {
            throw new System.NotImplementedException();
        }

        // TODO: Implement MoveDown() → Y increases by 1
        public void MoveDown()
        {
            throw new System.NotImplementedException();
        }

        // TODO: Implement MoveRight() → X increases by 1
        public void MoveRight()
        {
            throw new System.NotImplementedException();
        }

        // TODO: Implement MoveLeft() → X decreases by 1
        public void MoveLeft()
        {
            throw new System.NotImplementedException();
        }
    }
}
