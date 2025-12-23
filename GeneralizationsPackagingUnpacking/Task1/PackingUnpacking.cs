namespace Task1
{
    internal class PackingUnpacking
    {
        public float CalculateSum(List<object> objects)
        {
            float sum = 0;

            foreach (object obj in objects)
            {
                if (obj is int)
                {
                    sum += (int)obj;
                }

                else if (obj is float)
                {
                    sum += (float)obj;
                }
            }

            return sum;
        }
    }
}
