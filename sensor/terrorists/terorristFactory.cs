namespace sensor.models
{
    public class terorristFactory
    {
        public Random rnd = new Random();
        public List<string> sensorType = new List<string> {"audio", "thermal", "pulse", "magnetic", "signal" };
        public Terorrist creatTerorrist(string type)
        {
            Terorrist newTerorrist = null;
            SensorFactory sensor = new SensorFactory();

            switch (type)
            {
                case "foot soldier":
                    newTerorrist = new FootSoldier(type);
                    for (int i = 0; i < 2; i++) 
                    {
                        newTerorrist.SuitableSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]));
                    }
                    break;
                case "squad leader":
                    newTerorrist = new SquadLeader(type);
                    for (int i = 0; i < 4; i++) 
                    {
                        newTerorrist.SuitableSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]));
                    }
                    break;
                case "senior commander":
                    newTerorrist = new SeniorCommander(type);
                    for (int i = 0; i < 6; i++)
                    {
                        newTerorrist.SuitableSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]));
                    }
                    break;
                case "organization leader":
                    newTerorrist = new OrganizationLeader(type);
                    for (int i = 0; i < 8; i++)
                    {
                        newTerorrist.SuitableSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]));
                    }
                    break;
                default:
                    break;
            }
            return newTerorrist;

        }
    }
}
