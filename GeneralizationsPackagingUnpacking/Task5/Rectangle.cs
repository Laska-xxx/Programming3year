namespace Task5
{
    internal class Rectangle<T, T1> : Figure
    {
        public T Width { get; }
        public T1 Height { get; }

        public Rectangle(Vector2 center, T width, T1 height) : base(center)
        {
            Width = width;
            Height = height;
        }

        public override Vector2 MinPoint()
        {
            double width = Convert.ToDouble(Width);
            double height = Convert.ToDouble(Height);
            return new Vector2(Center.X - (width / 2), Center.Y - (height / 2));
        }

        public override Vector2 MaxPoint()
        {
            double width = Convert.ToDouble(Width);
            double height = Convert.ToDouble(Height);
            return new Vector2(Center.X + (width / 2), Center.Y + (height / 2));
        }
    }
}
