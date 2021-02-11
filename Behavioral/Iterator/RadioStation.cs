namespace Iterator
{
    public class RadioStation
    {
        private int _frequence;

        public RadioStation(int frequence) => _frequence = frequence;

        public int GetFrequency() => _frequence;
    }
}