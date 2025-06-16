namespace sensor.models
{
    public class Singel
    {
        public Singel(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            this.activ = true;
            Console.WriteLine($"this agent rank is {terorrist.Name}");
        }
}

