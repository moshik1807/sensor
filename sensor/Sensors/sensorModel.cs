namespace sensor.models
{
    public abstract class Sensor
    {
        public bool activ = false;
        public string Name;
        public Sensor(string name)
        {
            Name = name;
        }
        public abstract void Activate(Terorrist terorrist);
     
    }
}

