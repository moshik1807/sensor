namespace sensor.models
{
    public class Thermal
    {
        Random rnd = new Random();
        public Thermal(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            if (terorrist.SuitableSensors != null)
            {
                Console.WriteLine(terorrist.SuitableSensors[rnd.Next(0, terorrist.SuitableSensors.Count())]);
            }
        }
    }
}

