namespace _02._Zoo
{
    public class Animal
    {
        private string name;
        public Animal(string name)
        {
            Name = name;
        }
        public string Name { get => name; set => name = value; }
    }
}
