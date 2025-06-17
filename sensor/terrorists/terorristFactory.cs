using System.Xml.Schema;

namespace sensor.models
{
    public class terorristFactory
    {
        public Random rnd = new Random();
        public List<string> sensorType = new List<string> {"audio", "thermal", "pulse", "magnetic", "signal" };

        public List<Sensor> randomSensorsLisst(int number)
        {
            List<Sensor> sensorsList = new List<Sensor>();
            SensorFactory sensor = new SensorFactory();
            for (int i = 0; i < number; i++)
            {
                sensorsList.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]));
            }
            return sensorsList;
        }

        public Terorrist creatTerorrist(string rank)
        {
            Terorrist newTerorrist = null;
            switch (rank)
            {
                case "foot soldier":
                    newTerorrist = new FootSoldier(rank);
                    newTerorrist.SuitableSensors = randomSensorsLisst(2);
                    break;
                case "squad leader":
                    newTerorrist = new SquadLeader(rank);
                    newTerorrist.SuitableSensors = randomSensorsLisst(4);
                    break;
                case "senior commander":
                    newTerorrist = new SeniorCommander(rank);
                    newTerorrist.SuitableSensors = randomSensorsLisst(6);
                    break;
                case "organization leader":
                    newTerorrist = new OrganizationLeader(rank);
                    newTerorrist.SuitableSensors = randomSensorsLisst(8);
                    break;
                default:
                    break;
            }
            return newTerorrist;

        }
    }
}
