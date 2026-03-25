using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using PredatorPrey.Contracts;

namespace PredatorPrey
{
    /// <summary>
    /// Abstract base class for all animals.
    /// Provides shared logic for display, movement, aging, and death.
    /// Subclasses only need to implement TryBreed().
    /// </summary>
    public abstract class Animal : IAnimal
    {
        // One shared Random instance for the entire class hierarchy.
        // Why static? Creating a new Random() rapidly can produce the same seed → same "random" numbers.
        private static readonly Random _randomGenerator = new Random();

        private readonly int _maximumAge;
        private readonly Color _color;
        private Ellipse _ellipse;   // the WPF shape drawn on the canvas
        private Canvas _canvas;     // we keep this so StopDisplaying() can remove the ellipse

        // Protected so subclasses (Louse, LadyBug) can read the age to decide when to breed.
        protected int _age;

        public Position Position { get; }
        public bool IsDead { get; set; }

        // Constructor 1: random starting position on the 16×16 grid
        protected Animal(int maximumAge, Color color)
            : this(maximumAge, color, new Position(_randomGenerator.Next(16), _randomGenerator.Next(16)))
        {
            // Delegates to constructor 2 — avoids duplicating initialization logic.
        }

        // Constructor 2: explicit starting position (used when a newborn appears at the parent's location)
        protected Animal(int maximumAge, Color color, Position position)
        {
            _maximumAge = maximumAge;
            _color = color;
            _age = 0;
            Position = position;
        }

        // ── IDisplayable ────────────────────────────────────────────────────────

        public void DisplayOn(Canvas canvas)
        {
            _canvas = canvas;

            // The world is a 16×16 grid. Each cell is 10 pixels wide/tall.
            // The ellipse has a diameter of 5 pixels, placed at (X*10, Y*10).
            _ellipse = new Ellipse
            {
                Margin = new System.Windows.Thickness(Position.X * 10, Position.Y * 10, 0, 0),
                Width = 5,
                Height = 5,
                Fill = new SolidColorBrush(_color)
            };
            canvas.Children.Add(_ellipse);
        }

        public void StopDisplaying()
        {
            // TODO: Remove _ellipse from _canvas.Children so it disappears from the screen.
            throw new NotImplementedException();
        }

        public void UpdateDisplay()
        {
            // TODO: Update _ellipse.Margin to reflect the animal's current Position.
            //       Use the same formula as in DisplayOn (X * 10, Y * 10).
            throw new NotImplementedException();
        }

        // ── IAnimal ─────────────────────────────────────────────────────────────

        public void Move()
        {
            // TODO:
            //   1. Increment _age by 1.
            //   2. Pick a random direction (0–3) and call the matching Position.MoveXxx() method.
            //   3. Call UpdateDisplay() so the ellipse moves on screen.
            //   4. If _age exceeds _maximumAge, set IsDead = true.
            throw new NotImplementedException();
        }

        // Subclasses know their own breeding rules, so TryBreed stays abstract.
        public abstract IAnimal TryBreed();
    }
}
