namespace Task5
{
    internal class Circle : Figure
    {
        public dynamic Radius { get; }

        public Circle(Vector2 center, dynamic radius) : base(center)
        {
            Radius = radius;
        }

        public override Vector2 MinPoint()
        {
            return new Vector2 (Center.X - Radius, Center.Y - Radius);
        }

        public override Vector2 MaxPoint()
        {
            return new Vector2(Center.X + Radius, Center.Y + Radius);
        }
    }
}
