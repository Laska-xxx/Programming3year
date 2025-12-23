namespace Task4
{
    internal class Circle : Figure
    {
        private dynamic _radius;

        public dynamic Radius 
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public Circle(Vector2 center, dynamic radius) : base(center)
        {
            Radius = radius;
        }

        public void SetRadius<T>(T radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Convert.ToDouble(_radius), 2);
        }

        public override string ToString()
        {
            return $"Radius: {Radius}, Area: {Area()}";
        }
    }
}
