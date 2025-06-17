namespace sensor.models
{
    public class Magnetic : Sensor
    {
        public Magnetic(string name) : base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            this.activ = true;
            terorrist.AttackBlocker ++;
            Console.WriteLine("You guessed it, that's why the next counterattack is canceled.");
        }
    }
}

