namespace sensor.models
{
    public class Thermal: Sensor
    {
        Random rnd = new Random();
        public Thermal(string name):base(name)
        {
        }
        public override void Activate(Terorrist terorrist,string name)
        {
            if (this.Name == name && !this.activ)
            {
                this.activ = true;
                List<Sensor> noActive = new List<Sensor>();
                foreach (var sensor in terorrist.SuitableSensors)
                {
                    if (!sensor.activ)
                    {
                        noActive.Add(sensor);
                    }
                }
                if (noActive.Count != 0)
                {
                    Console.WriteLine($"one of the elements is:{noActive[rnd.Next(0, noActive.Count())].Name}");

                }
            }
        }
    }
}

