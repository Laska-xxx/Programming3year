namespace Task5
{
    internal abstract class Figure
    {
        public Vector2 Center { get; }

        public Figure(Vector2 center)
        {
            Center = center;
        }

        public abstract Vector2 MinPoint();

        public abstract Vector2 MaxPoint();
    }
}
