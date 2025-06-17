using System.Diagnostics.Metrics;
using System.Reflection;

namespace sensor.models
{
    public class Menu
    {
        
        public Menu()
        {
            Terorrist terorrist1 = new terorristFactory().creatTerorrist("foot soldier");
            Terorrist terorrist2 = new terorristFactory().creatTerorrist("squad leader");
            Terorrist terorrist3 = new terorristFactory().creatTerorrist("senior commander");
            Terorrist terorrist4 = new terorristFactory().creatTerorrist("organization leader");
            List<Terorrist> terorristList = new List<Terorrist> { terorrist1, terorrist2, terorrist3, terorrist4 };
            foreach(var terorrist in terorristList)
            {
                Game(terorrist);
            }
        }
        
        public void Game(Terorrist terorrist)
        {
            int Mistakes = 0;
            while (true)
            {
                Console.Write("Enter sensor type: ");
                string input = Console.ReadLine();
                bool foundMatch = false;

                // מאפס סנסורים אם טעה 10 פעמים
                if (Mistakes >= 10)
                {
                    foreach(var sensor in terorrist.SuitableSensors)
                    {
                        sensor.activ = false;
                    }
                    Console.WriteLine("You have 10 mistakes, the list has been reset.");
                    Mistakes = 0;
                }
                //בדיקה אם ניחש נכון ואם כן להדליק את אותו הסנסור 
                foreach (var sensor in terorrist.SuitableSensors)
                {
                    if (sensor.Name == input && !sensor.activ)
                    {
                        sensor.Activate(terorrist);
                        foundMatch = true;
                        break;
                    }
                }
                terorrist.Counterattack();

                //סופר כמה סנסורים דלוקים ומדפיס הודעה בהתאם
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
                    Mistakes++;
                    Console.WriteLine("Incorrect or already activated. Try again.");
                    Console.WriteLine($"you heav: {activeCount}/{terorrist.SuitableSensors.Count()}");
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

