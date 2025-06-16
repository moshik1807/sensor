namespace sensor.models
{
    public abstract class Terorrist
    {
        public List<Sensor> SuitableSensors = new List<Sensor>();
        public string Name;
        public int counter = 0;
        public int counter2 = 0;
        public Terorrist(string name)
        {
            Name = name;
        }
        public abstract void protection();
    }
}

