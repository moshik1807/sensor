namespace sensor.models
{
    public class OrganizationLeader:Terorrist
    {
        public OrganizationLeader(string name):base(name)
        {
            counterAttack = 3;
        }
        public override void protection()
        {
            this.counter++;
            if (this.counter >= counterAttack)
            {
                foreach (var sensor in this.SuitableSensors)
                {
                    if (sensor.activ)
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

