namespace sensor.models
{
    public class SeniorCommander:Terorrist
    {
        public SeniorCommander(string name):base(name)
        {
            counterAttack = 3;
        }
        public override void protection()
        {
            this.counter++;
            if (this.counter >= counterAttack)
            {
                int temp = 0;
                foreach (var sensor in this.SuitableSensors)
                {
                    if (sensor.activ)
                    {
                        sensor.activ = false;
                        this.counter = 0;
                        temp++;
                    }
                    if(temp == 2)
                    {
                        break;
                    }
                }
            }
        }



    }
}

