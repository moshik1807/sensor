namespace sensor.models
{
    public class terorristFactory
    {
        public Random rnd = new Random();
        public List<string> sensorType = new List<string> { "audio", "thermal" };
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
                default:
                    break;
            }
            return newTerorrist;

        }
    }
}
//, "Pulse", "Motion", "Magnetic", "Signal", "Light"
