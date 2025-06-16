namespace sensor.models
{
    public class SquadLeader:Terorrist
    {
        public SquadLeader(string name) : base(name)
        {
        }
        public override void protection()
        {
            this.counter++;
            if (this.counter >= 3)
            {
                foreach (var sensor in this.SuitableSensors)
                {
                    if(sensor.activ)
                    {
                        sensor.activ = false;
                        this.counter = 0;
                        break;
                    }
                }
            }
        }

    }
}

