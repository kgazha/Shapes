using ShapeHelper.Implementations;
using ShapeHelper.Interfaces;

namespace ShapeHelper.Domain
{
    public class Circle : ICircle
    {
        private readonly ICircle _circle;

        public Circle(ICircle circle)
        {
            _circle = circle;
        }

        public Circle(int radius)
        {
            _circle = new CircleWithRadius(radius);
        }

        public string Name => _circle.Name;
        public double GetSquare() => _circle.GetSquare();
    }
}
