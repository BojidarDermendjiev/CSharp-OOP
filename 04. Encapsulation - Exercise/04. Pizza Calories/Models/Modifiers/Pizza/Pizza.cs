namespace _04._Pizza_Calories.Models.Modifiers.Pizza
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Dough;
    using Topping;
    using Utilities.Messages;
    public class Pizza : IPizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 0 && 15 < value.Length)
                    throw new Exception(string.Format(ExcaptionMessages.PIZZA_NUMBER_SHOULD_BE_BETWEEN_1_TO_15SYMBOLS));
                name = value;
            }
        }
        public Dough Dough { get => dough; private set => dough = value; }
        public int Count => toppings.Count;
        public void AddTopping(Topping topping)
        {
            if (this.Count == 10)
                throw new ArgumentException(string.Format(ExcaptionMessages.PIZZA_TOPPING_CAPACITY_SHOULD_BE_IN_RANGE_TO_50));
            toppings.Add(topping);
        }
        public double TotalCalories
        {
            get
            {
                double totalCalories = this.dough.GetCalories();
                foreach (Topping topping in toppings)
                    totalCalories += topping.GetCalories();
                return totalCalories;
            }
        }
        public override string ToString()
        => $"{this.name} - {this.TotalCalories:f2} Calories.";

    }
}
