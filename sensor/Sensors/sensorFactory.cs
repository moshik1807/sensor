namespace sensor.models
{
    public class SensorFactory
    {
        public Sensor createSensor(string type)
        {
            Sensor sensor = null;
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
                case "magnetic":
                    Magnetic magnetic = new Magnetic(type);
                    sensor = magnetic;
                    break;
                case "signal":
                    Signal singel = new Signal(type);
                    sensor = singel;
                    break;
                default:
                    break;
            }
            return sensor;
        }

    }
}

