namespace sensor.models
{
    public abstract class Sensor
    {
        public string Name;
        public Sensor(string name)
        {
            Name = name;
        }
        public abstract void Activate();
     
    }
}

