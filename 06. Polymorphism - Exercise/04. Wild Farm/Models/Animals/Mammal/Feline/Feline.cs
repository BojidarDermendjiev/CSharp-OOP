namespace _04._Wild_Farm.Models.Animals.Mammal.Feline
{
    using Utilities.Messages;
    public abstract class Feline : Mammal
    {
        protected abstract string Breed { get; set; }
        protected Feline(string name, double weight, string livingRegion, string breeed) : base(name, weight, livingRegion)
        {
            Breed = breeed;
        }
        public override string ToString()
            => string.Format(OutputMessages.FELING_TO_STRING, this.GetType().Name, Name, Breed, Weight, LivingRegion, FoodEaten);
    }
}
