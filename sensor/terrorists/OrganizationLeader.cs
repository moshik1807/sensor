namespace sensor.models
{
    public class OrganizationLeader:Terorrist
    {
        public OrganizationLeader(string name):base(name)
        {
        }
        public override void protection()
        {
            this.counter++;
            this.counter2++;
            if (this.counter >= 3)
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

            //if (this.counter2 >= 10)
            //{
            //    foreach (var sensor in this.SuitableSensors)
            //    {
            //        if (sensor.activ)
            //        {
            //            sensor.activ = false;
            //        }
            //    }
            //    this.counter2 = 0;
            //}

        }




    }
}

