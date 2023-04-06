namespace _06._Animals
{
    using System;
    using System.Linq;

    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal()
        { }
        public Animal(string name, int age, string gender) : this()
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new InvalidOperationException();
                name = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new InvalidOperationException();
                age = value;
            }
        }
        public virtual string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new InvalidOperationException();
                gender = value;
            }
        }
        public virtual string ProduceSount()
            => null;
        public override string ToString()
            => this.GetType().ToString().Split('.').Last() + Environment.NewLine + $"{Name} {Age} {Gender}" + Environment.NewLine + ProduceSount();

    }
}
