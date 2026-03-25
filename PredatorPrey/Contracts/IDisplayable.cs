using System.Windows.Controls;

namespace PredatorPrey.Contracts
{
    /// <summary>
    /// Anything that can be drawn on a WPF Canvas and later removed or repositioned.
    /// </summary>
    public interface IDisplayable
    {
        /// <summary>Adds this object's visual to the given canvas.</summary>
        void DisplayOn(Canvas canvas);

        /// <summary>Removes this object's visual from the canvas.</summary>
        void StopDisplaying();

        /// <summary>Refreshes the position of the visual on the canvas (e.g. after moving).</summary>
        void UpdateDisplay();
    }
}
