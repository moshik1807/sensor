namespace sensor.models
{
    public class OrganizationLeader:Terorrist
    {
        public OrganizationLeader(string rank) :base(rank)
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
                    foreach (var sensor in this.SuitableSensors)
                    {
                        if (sensor.activ)
                        {
                            sensor.activ = false;
                            this.counter = 0;
                            Console.WriteLine("A counterattack was carried out and one sensor was disabled.");
                            break;
                        }
                    }
                }
            }
        }




    }
}

