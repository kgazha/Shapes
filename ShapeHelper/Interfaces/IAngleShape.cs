namespace ShapeHelper.Interfaces
{
    /// <summary>
    /// Interface for angular shapes
    /// </summary>
    public interface IAngularShape
    {
        /// <summary>
        /// Determine if a shape has a right angle or not
        /// </summary>
        /// <returns>Returns true if a shape has a right angle</returns>
        bool HasRightAngle();
    }
}
