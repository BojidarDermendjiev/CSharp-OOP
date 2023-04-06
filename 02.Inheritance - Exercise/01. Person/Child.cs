namespace _01._Person
{
    public class Child : Person
    {
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value >= 0 && value <= 15)
                    base.Age = value;
            }
        }
        public Child(string name, int age) : base(name, age) { }
    }
}
