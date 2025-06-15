namespace sensor.models
{
    public class Menu
    {

        public Menu()
        {
            terorristFactory xxxx = new terorristFactory();
            Terorrist terrorist = xxxx.creatTerorrist("foot soldier");
            Game(terrorist);
        }

        public void Game(Terorrist terorrist)
        {
            int counter = 0;

            while (counter < terorrist.SuitableSensors.Count())
            {
                Console.Write("Enter sensor type:");
                string input = Console.ReadLine();
                bool foundMatch = false;
                foreach (var sensor in terorrist.SuitableSensors)
                {
                    if (sensor.Name == input && !sensor.activ)
                    {
                        sensor.Activate(terorrist, input);
                        sensor.activ = true;
                        counter++;
                        foundMatch = true;
                        Console.WriteLine($"Correct! Progress: {counter}/{terorrist.SuitableSensors.Count()}");
                        break;
                    }
                }
                if (!foundMatch)
                {
                    Console.WriteLine("Incorrect or already activated. Try again.");
                }
            }
            Console.WriteLine("Winner!");
        }
    }
}

