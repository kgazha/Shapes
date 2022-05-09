using ShapeHelper.Interfaces;
using System;
using System.Linq;

namespace ShapeHelper.Behaviours
{
    public class TriangleWithEdges : ITriangle
    {
        private readonly double _firstEdge;
        private readonly double _secondEdge;
        private readonly double _thirdEdge;
        private readonly string _name;

        /// <summary>
        /// Triangle with initial edges
        /// </summary>
        /// <param name="a">First edge</param>
        /// <param name="b">Second edge</param>
        /// <param name="c">Third edge</param>
        /// <exception cref="ArgumentOutOfRangeException">If any parameter is less than or equal to zero</exception>
        public TriangleWithEdges(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("Parameter value must be greater than zero");

            _name = "Triangle";
            _firstEdge = a;
            _secondEdge = b;
            _thirdEdge = c;
        }

        public string Name => _name;

        public double GetSquare()
        {
            double semiperimeter = (_firstEdge + _secondEdge + _thirdEdge) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _firstEdge) * (semiperimeter - _secondEdge) * (semiperimeter - _thirdEdge));
        }

        public bool HasRightAngle()
        {
            var maxEdge = new double[] { _firstEdge, _secondEdge, _thirdEdge }.Max();
            var maxEdgeSquare = Math.Pow(maxEdge, 2);
            return 2 * maxEdgeSquare == Math.Pow(_firstEdge, 2) + Math.Pow(_secondEdge, 2) + Math.Pow(_thirdEdge, 2);
        }
    }
}
