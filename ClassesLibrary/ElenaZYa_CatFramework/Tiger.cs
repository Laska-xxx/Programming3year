namespace ElenaZYa_CatFramework
{
    public class Tiger : Cat
    {
        private int _fluffiness;
        public override int Fluffiness { get {  return _fluffiness; } }
        public double Weight { get; }

        public Tiger(int fluffiness = 50, double weight = 50)
        {
            bool fluffinessError = false;
            bool weightError = false;
            string mes = "";

            if (fluffiness < 0 || fluffiness > 100)
            {
                fluffinessError = true;
                mes += $"Unable to create a tiger with fluffiness {fluffiness}\n";
            }

            if (weight < 75.0f || weight > 140.0f)
            {
                weightError = true;
                mes += $"Unable to create a tiger with weight: {weight}\n";
            }

            if (fluffinessError || weightError)
            {
                throw new CatException(mes);
            }

            _fluffiness = fluffiness;
            Weight = weight;
        }

        public override string FluffinessCheck()
        {
            return "Kycb!";
        }

        public override string ToString()
        {
            return $"A tiger with weight: {Weight} fluffiness: {Fluffiness}";
        }
    }
}
