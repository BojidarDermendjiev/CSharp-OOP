namespace _02._Animal_Farm.Utilities.Messages
{
    using System;
    public class AgeArgumentValueShouldBeBetween0To15 : Exception
    {
        private const string AGE_VALUE_SHOULD_BE_BETWEEN_0TO15 = "Age should be between 0 and 15.";
        public AgeArgumentValueShouldBeBetween0To15() : base(AGE_VALUE_SHOULD_BE_BETWEEN_0TO15) { }
        public AgeArgumentValueShouldBeBetween0To15(string message) : base(message) { }
    }
}
