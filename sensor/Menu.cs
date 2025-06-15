namespace sensor.models
{
    public class Menu
    {

        public Menu()
        {
            Audio audio = new Audio("ss");
            Thermal thermal = new Thermal("tt");
            audio.Activate();
            audio.Activate();
            Console.WriteLine(audio.Name);
            Terorrist n = new Terorrist("n");
            Console.WriteLine(n.Checked(audio));
            
        }
        public void Game()
        {
            Console.WriteLine("ENTER");
            string coice = Console.ReadLine();
            switch (coice)
            {
                case "a":
                    break;
            }
               
        }

    }
}

