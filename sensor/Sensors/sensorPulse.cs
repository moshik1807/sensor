namespace sensor.models
{
    public class Pulse : Sensor
    {
        public Pulse(string name) : base(name)
        {
        }
        public override void Activate(Terorrist terorrist)
        {
            this.activ = true;
            counter++;
            if (counter >= 3)
            {
                foreach(var sensor in terorrist.SuitableSensors)
                {
                    if(sensor.Name == "pulse")
                    {
                        sensor.activ = false;
                        counter = 0;
                        break;
                    }
                }
            }
        }
    }
}

