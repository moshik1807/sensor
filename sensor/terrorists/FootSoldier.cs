namespace sensor.models
{
    public class FootSoldier:Terorrist
    {
        public FootSoldier(string name):base(name)
        {
        }
        public override void protection()
        {
            Console.WriteLine("He has no defense");
        }

    }
}

