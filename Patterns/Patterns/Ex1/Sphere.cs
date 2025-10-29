namespace Patterns.Ex1
{
    internal class Sphere : IFigure
    {
        public int _radius;

        public Sphere(int radius)
        {
            _radius = radius;
        }

        public IFigure Clone()
        {
            return new Sphere(_radius);
        }

        public override string ToString()
        {
            return $"Сфера радиусом {_radius}";
        }
    }
}
