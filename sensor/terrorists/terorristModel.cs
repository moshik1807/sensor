using System.Diagnostics.Metrics;

namespace sensor.models
{
    public abstract class Terorrist
    {
        public List<Sensor> SuitableSensors = new List<Sensor>();
        public string Name;
        public int counter = 0;
        public int counterAttack;
        public Terorrist(string name)
        {
            Name = name;
        }
        public abstract void protection();
    }
}

