namespace Task5
{
    internal class Square : Figure
    {
        public dynamic Width { get; }
        public Square(Vector2 center, dynamic width) : base(center)
        {
            Width = width;
        }

        public override Vector2 MinPoint()
        {
            return new Vector2(Center.X - (Width / 2), Center.Y - (Width / 2));
        }

        public override Vector2 MaxPoint()
        {
            return new Vector2 (Center.X + (Width / 2), Center.Y + (Width / 2));
        }
    }
}
