namespace sensor.models
{
    public class SensorFactory
    {
        public Sensor sensor = null;
        public Sensor createSensor(string type)
        {
            //EnterType();
            switch (type)
            {
                
                case "audio":
                    Audio audio = new Audio(type);
                    sensor = audio;
                    break;
                case "thermal":
                    Thermal thermal = new Thermal(type);
                    sensor = thermal;
                    break;
                case "pulse":
                    Pulse pulse = new Pulse(type);
                    sensor = pulse;
                    break;
                default:
                    break;
            }
            return sensor;
        }

    }
}

