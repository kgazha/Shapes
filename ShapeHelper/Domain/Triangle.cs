using ShapeHelper.Behaviours;
using ShapeHelper.Interfaces;

namespace ShapeHelper.Domain
{
    public class Triangle : ITriangle
    {
        private readonly ITriangle _triangle;

        public Triangle(ITriangle triangle)
        {
            _triangle = triangle;
        }

        public Triangle(double a, double b, double c)
        {
            _triangle = new TriangleWithEdges(a, b, c);
        }

        public Triangle(double triangleBase, double height)
        {
            _triangle = new TriangleWithBaseAndHeight(triangleBase, height);
        }

        public string Name => _triangle.Name;
        public double GetSquare() => _triangle.GetSquare();
        public bool HasRightAngle() => _triangle.HasRightAngle();
    }
}
