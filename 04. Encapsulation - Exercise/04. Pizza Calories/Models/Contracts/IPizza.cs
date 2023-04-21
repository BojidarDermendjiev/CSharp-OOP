namespace _04._Pizza_Calories.Models.Contracts
{
    using System.Collections.Generic;
    using Modifiers.Dough;
    using Modifiers.Topping;
    public interface IPizza
    {
        public string Name { get; }
        public Dough Dough { get; }
    }
}
