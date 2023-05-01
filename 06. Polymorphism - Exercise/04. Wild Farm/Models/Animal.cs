namespace _04._Wild_Farm.Models
{
    using Models.Contracts;
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = default;
        }
        protected abstract string Name { get; set; }

        protected abstract double Weight { get; set; }

        protected abstract int FoodEaten { get; set; }

        protected abstract double WeightGain { get; }
        public abstract void Eat(Food food);
        public abstract string Sound();
    }
}
