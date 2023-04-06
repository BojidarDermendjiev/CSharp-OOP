namespace _03._Players_and_Monsters
{
    public class Hero
    {
        private string username;
        private int level;
        public Hero(string username, int level)
        {
            UserName = username;
            Level = level;
        }
        public string UserName 
        {
            get => username;
            set => username = value;
        }
        public int Level 
        { 
            get => level; 
            set => level = value;
        }
        public override string ToString()
            => $"Type: {this.GetType().Name} Username: {UserName} Level: {Level}";
    }
}
