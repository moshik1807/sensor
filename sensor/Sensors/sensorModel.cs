namespace sensor.models
{
    public abstract class Sensor
    {
        public bool activ = false;
        public string Name;
        public int counter = 0;
        public Sensor(string name)
        {
            Name = name;
        }
        public abstract void Activate(Terorrist terorrist,string name);
     
    }
}

