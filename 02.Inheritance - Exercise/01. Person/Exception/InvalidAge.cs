namespace _01._Person.Exception
{
    using System;
    public class InvalidAge : Exception
    {
        private const string DEFAULTEXCEPTIONMESSAGE = "Invalid number!";
        public InvalidAge() : base(DEFAULTEXCEPTIONMESSAGE) { }
        public InvalidAge(string message) : base(message) { }

    }
}
