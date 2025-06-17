namespace sensor.models
{
    public class SeniorCommander:Terorrist
    {
        public SeniorCommander(string rank) :base(rank)
        {
        }
        public override void Counterattack()
        {
            this.counter++;
            if (this.counter >= 3)
            {
                if(AttackBlocker > 0)
                {
                    AttackBlocker--;
                    this.counter = 0;
                }
                else
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
                        if (temp == 2)
                        {
                            break;
                        }
                    }
                }
            }
        }



    }
}

