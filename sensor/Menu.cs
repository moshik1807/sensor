using System.Diagnostics.Metrics;
using System.Reflection;

namespace sensor.models
{
    public class Menu
    {

        public Menu()
        {
            terorristFactory xxxx = new terorristFactory();
            Terorrist terrorist = xxxx.creatTerorrist("squad leader");
            Game(terrorist);
        }

        public void Game(Terorrist terorrist)
        {
            while (true)
            {
                Console.Write("Enter sensor type: ");
                string input = Console.ReadLine();
                bool foundMatch = false;

                foreach (var sensor in terorrist.SuitableSensors)
                {
                    if (sensor.Name == input && !sensor.activ)
                    {
                        sensor.Activate(terorrist, input);
                        foundMatch = true;
                        break;
                    }
                }
                terorrist.protection();


                int activeCount = 0;
                foreach(var t in terorrist.SuitableSensors)
                {
                    if(t.activ)
                    {
                        activeCount++;
                    }
                }

                if (foundMatch)
                {
                    Console.WriteLine($"Correct! Progress: {activeCount}/{terorrist.SuitableSensors.Count()}");
                }
                else
                {
                    Console.WriteLine("Incorrect or already activated. Try again.");
                }

                if (activeCount == terorrist.SuitableSensors.Count())
                {
                    Console.WriteLine("you won!");
                    break;
                }
            }
        }
    }
}

