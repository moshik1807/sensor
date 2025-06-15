namespace sensor.models
{
    public class terorristFactory
    {
        public Terorrist terorrist = null;
        public Random rnd = new Random();
        public List<string> sensorType = new List<string> { "audio", "thermal" };
        public Terorrist creatTerorrist(string type)
        {
            switch (type)
            {
                case "foot soldier":
                    FootSoldier footSoldier = new FootSoldier(type);
                    for (int i = 0;i <= 1;i++)
                    {
                        SensorFactory sensor = new SensorFactory();
                        footSoldier.SuitableSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, 2)]));
                        terorrist = footSoldier;
                    }
                    break;
                case "":
                    break;
            }
            return terorrist;

        }
    }
}
//, "Pulse", "Motion", "Magnetic", "Signal", "Light"
