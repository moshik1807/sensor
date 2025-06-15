namespace sensor.models
{
    public abstract class Terorrist
    {
        public List<Sensor> SuitableSensors = new List<Sensor>();
        public string Name;
        public Terorrist(string name)
        {
            Name = name;
        }
        public abstract void protection();
    }
}

