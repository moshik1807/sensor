namespace sensor.models
{
    public class Audio:Sensor
    {

        public Audio(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            foreach(var sensor in terorrist.SuitableSensors)
            {
                if (sensor.Name == Name && !sensor.activ)
                {
                    sensor.activ = true;
                    Console.WriteLine("Listening has begun.");
                    break;
                }
            }
        }
    }
}
