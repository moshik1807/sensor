namespace sensor.models
{
    public class Terorrist
    {
        public List<string> SensorsActivated = new List<string>();
        public List<Sensor> SuitableSensors = new List<Sensor>();
        public string Name;
        public Terorrist(string name)
        {
            Name = name;
        }
    }
}

