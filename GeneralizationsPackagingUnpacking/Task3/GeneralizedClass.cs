namespace Task3
{
    internal class GeneralizedClass<T>
    {
        public T Value { get; set; }

        public GeneralizedClass(T value)
        {
            Value = value;
        }

        public void Reset()
        {
            Value = default(T);
        } 
    }
}
