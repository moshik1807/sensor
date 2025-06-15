namespace sensor.models
{
    public class Thermal: Sensor
    {
        Random rnd = new Random();
        public Thermal(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            foreach (var sensor in terorrist.SuitableSensors)
            {
                if (sensor.Name == Name && !sensor.activ)
                {
                    sensor.activ = true;
                    Console.WriteLine(terorrist.SuitableSensors[rnd.Next(0, terorrist.SuitableSensors.Count())].Name);
                    break;
                }
            }
        }
    }
}

