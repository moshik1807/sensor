namespace sensor.models
{
    public class Terorrist
    {
        public List<string> SensorsActivated = new List<string>();
        public List<string> SuitableSensors = new List<string>();
        string Name;
        public Terorrist(string name)
        {
            Name = name;
        }
        public bool Checked(Sensor sensor)
        {
            return (SuitableSensors.Contains(sensor.Name));
        }
            

    }
}

