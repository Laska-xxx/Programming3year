namespace Task5
{
    internal class Vector2
    {
        public double X { get; }
        public double Y { get; }

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}; {Y})";
        }
    }
}
