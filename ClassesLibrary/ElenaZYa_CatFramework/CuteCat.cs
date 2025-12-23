namespace ElenaZYa_CatFramework
{
    public class CuteCat : Cat
    {
        private int _fluffiness;
        public override int Fluffiness { get { return _fluffiness; } }

        public CuteCat(int fluffiness = 50)
        {
            string mes = "";

            if (fluffiness < 0 || fluffiness > 140)
            {
                mes = $"Unable to create a cute cat with fluffiness: {fluffiness}\n";
                throw new CatException(mes);
            }

            _fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            if (Fluffiness == 0)
            {
                return "Sphynx";
            }

            else if (Fluffiness <= 20)
            {
                return "Slightly";
            }

            else if (Fluffiness <= 50)
            {
                return "Medium";
            }

            else if (Fluffiness <= 75)
            {
                return "Heavy";
            }

            else if (Fluffiness == 140)
            {
                return "OMG, this is the softest cat I've ever checked!";
            }

            else
            {
                return "OwO";
            }
        }

        public override string ToString()
        {
            return $"A cute cat with fluffiness: {Fluffiness}";
        }
    }
}
