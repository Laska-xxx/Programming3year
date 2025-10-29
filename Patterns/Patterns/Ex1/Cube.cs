namespace Patterns.Ex1
{
    internal class Cube : IFigure
    {
        public int _width;
        public int _height;
        public int _depth;

        public Cube(int width, int height, int depth)
        {
            _width = width;
            _height = height;
            _depth = depth;
        }

        public IFigure Clone()
        {
            return new Cube( _width, _height, _depth );
        }

        public override string ToString()
        {
            return $"Куб {_width}*{_height}*{_depth}";
        }
    }
}
