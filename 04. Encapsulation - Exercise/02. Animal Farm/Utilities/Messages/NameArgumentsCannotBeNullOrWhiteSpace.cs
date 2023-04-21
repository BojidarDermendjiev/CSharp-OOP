namespace _02._Animal_Farm.Utilities.Messages
{
    using System;
    public class NameArgumentsCannotBeNullOrWhiteSpace : Exception
    {
        private const string NAME_CANNOT_BE_NULL_OR_WHITESPACE = "Name cannot be empty.";
        public NameArgumentsCannotBeNullOrWhiteSpace() : base(NAME_CANNOT_BE_NULL_OR_WHITESPACE) { }
        public NameArgumentsCannotBeNullOrWhiteSpace(string messgae) : base(messgae) { }
    }
}
