using ShapeHelper.Interfaces;
using System;

namespace ShapeHelper.Implementations
{
    public class CircleWithRadius : ICircle
    {
        private readonly double _radius;
        private readonly string _name;

        /// <summary>
        /// Circle with initial radius
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="ArgumentOutOfRangeException">If the radius is less than or equal to zero</exception>
        public CircleWithRadius(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Parameter value must be greater than zero");

            _name = "Circle";
            _radius = radius;
        }

        public string Name => _name;

        public double GetSquare() =>
            _radius * _radius * Math.PI;
    }
}
