namespace _06._Animals
{
    public class Kitten : Cat
    {
        private const string FIXED_GENDER = "Female";

        public override string Gender { get => FIXED_GENDER; }

        public Kitten(string name, int age)
            : base(name, age, null)
        { }

        public override string ProduceSount()
         => "Meow";
    }
}
