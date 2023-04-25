using System;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood) { }
        public override string ExceptionplainSelf()
            => base.ExceptionplainSelf() + Environment.NewLine + "DJAAF";
    }
}
