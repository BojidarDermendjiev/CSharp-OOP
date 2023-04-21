namespace _01._Class_Box_Data.Utilities.Messages
{
    using System;
    public class ExcaptionMessageWithAbstraction : Exception
    {
        private const string DefaultMessage = "{0} cannot be zero or negative.";
        public ExcaptionMessageWithAbstraction() : base(DefaultMessage) { }
        public ExcaptionMessageWithAbstraction(string message) : base(message) { }
    }
}
