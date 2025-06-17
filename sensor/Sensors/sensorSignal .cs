namespace sensor.models
{
    public class Signal:Sensor
    {
        public Signal(string name) : base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            this.activ = true;
            Console.WriteLine($"this agent rank is {terorrist.Rank}");
        }
    }
}

