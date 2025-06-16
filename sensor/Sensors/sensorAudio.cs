namespace sensor.models
{
    public class Audio:Sensor
    {

        public Audio(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
              this.activ = true;
              Console.WriteLine("Listening has begun.");
        }
    }
}
