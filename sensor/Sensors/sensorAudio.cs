namespace sensor.models
{
    public class Audio:Sensor
    {
        public Audio(string name):base(name)
        {
        }
        public override void Activate()
        {
            Console.WriteLine("Listening has begun.");
        }
    }

}
