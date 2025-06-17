using System.Diagnostics.Metrics;

namespace sensor.models
{
    public abstract class Terorrist
    {
        public List<Sensor> SuitableSensors = new List<Sensor>();
        public string Rank;
        public int counter = 0;
        public int AttackBlocker = 0;
        public Terorrist(string rank)
        {
            Rank = rank;
        }
        public abstract void Counterattack();
    }
}

