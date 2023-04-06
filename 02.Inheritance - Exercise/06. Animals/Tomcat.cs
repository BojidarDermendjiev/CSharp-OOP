namespace _06._Animals
{
    public class Tomcat : Cat
    {
        private const string FIXED_GENDER = "Male";

        public override string Gender { get => FIXED_GENDER; } 

        public Tomcat(string name, int age)
            : base(name, age, null)
        { }
        public override string ProduceSount()
         => "MEOW";
    }
}
