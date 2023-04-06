namespace _01._Person.Exception
{
    using System;
    public class InvalidName : Exception
    {
        private const string INCORRECT_NAME = "Invalid Name! Try Again!";
        public InvalidName() : base(INCORRECT_NAME) { }
        public InvalidName(string message) : base(message) { }
    }
}
