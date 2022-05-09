using ShapeHelper.Interfaces;
using System;

namespace ShapeHelper.Behaviours
{
    public class TriangleWithBaseAndHeight : ITriangle
    {
        private readonly double _height;
        private readonly double _base;
        private readonly string _name;

        /// <summary>
        /// Triangle with initial base and height
        /// </summary>
        /// <param name="triangleBase">Base of the triangle</param>
        /// <param name="height">Triangle height</param>
        /// <exception cref="ArgumentOutOfRangeException">If any parameter is less than or equal to zero</exception>
        public TriangleWithBaseAndHeight(double triangleBase, double height)
        {
            if (triangleBase < 0 || height < 0)
                throw new ArgumentOutOfRangeException("Parameter value must be greater than zero");

            _name = "Triangle";
            _base = triangleBase;
            _height = height;
        }

        public string Name => _name;

        public double GetSquare() => _height * _base * 0.5;

        public bool HasRightAngle() =>
            throw new NotImplementedException("Unable to check right angle");
    }
}
