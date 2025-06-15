namespace sensor.models
{
    public class Audio:Sensor
    {

        public Audio(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist,string name)
        {
            if (this.Name == name && !this.activ)
            {
                this.activ = true;
                Console.WriteLine("Listening has begun.");
            }
        }
    }
}
