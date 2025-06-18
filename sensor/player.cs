namespace sensor.models
{
    public class Player
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int CurrentLevel;
        public int NumberOfWins;
        public Player(int id,string firstName,string lastName, int currentLevel,int numberOfWins)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CurrentLevel = currentLevel;
            NumberOfWins = numberOfWins;
        }
    }

}
