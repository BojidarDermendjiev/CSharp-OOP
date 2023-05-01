namespace _04._Wild_Farm.Models.Animals.Mammal
{
    using Utilities.Messages;
    public abstract class Mammal : Animal
    {
        protected abstract string LivingRegion { get; set; }
        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }
        public abstract override void Eat(Food food);
        public abstract override string Sound();
        public override string ToString()
            => string.Format(OutputMessages.MAMMAL_TO_STRING, this.GetType().Name, Name, Weight, LivingRegion, FoodEaten);
    }
}
