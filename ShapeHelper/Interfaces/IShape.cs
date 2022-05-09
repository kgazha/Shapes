namespace ShapeHelper.Interfaces
{
    /// <summary>
    /// Common shape interface
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Name of a shape
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Calculate the square of a shape
        /// </summary>
        /// <returns>Square of the shape</returns>
        double GetSquare();
    }
}
