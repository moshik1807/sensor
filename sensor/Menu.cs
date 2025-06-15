namespace sensor.models
{
    public class Menu
    {

        public Menu()
        {
            Audio audio = new Audio("ss");
            Thermal thermal = new Thermal("tt");

            Console.WriteLine(audio.Name);
            Terorrist n = new Terorrist("n");
            n.SuitableSensors.Add(audio);
            n.SuitableSensors.Add(thermal);
            audio.Activate(n);
            audio.Activate(n);
            SensorFactory cc = new SensorFactory();
            cc.create();
            Game(n);
        }
        public void Game(Terorrist terorrist)
        {
            int caunter = 0;
            foreach(var t in terorrist.SuitableSensors)
            {
                if (t.activ)
                {
                    caunter ++;
                }
            }
            if(caunter == terorrist.SuitableSensors.Count())
            {
                Console.WriteLine("winer");
            }
            else
            {
                Console.WriteLine($"you heav {caunter}/{terorrist.SuitableSensors.Count()}");
            }
        }
        

    }
}

