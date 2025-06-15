namespace sensor.models
{
    public class SensorFactory
    {
        public string type;
        public Sensor sensor = null;
        public void EnterType()
        {
            Console.WriteLine("enter");
            type = Console.ReadLine();
        }
        public void create()
        {
            EnterType();
            switch (type)
            {
                case "audio":
                    Audio audio = new Audio(type);
                    break;
            }
        }

    }
}

