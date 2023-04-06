namespace _01._Person
{
    using _01._Person.Exception;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new InvalidName();
                name = value;
            }
        }
        public virtual int Age
        {
            get => age;
            set
            {
                if (age < 0)
                    throw new InvalidAge();
                age = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}, Age: {Age}");
            return sb.ToString().TrimEnd();
        }
    }
}
