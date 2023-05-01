using _04._Wild_Farm.Utilities.Messages;

namespace _04._Wild_Farm.Models.Animals.Bird
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }
        protected double WingSize { get; set; }
        public override string ToString()
            => string.Format(OutputMessages.BIRD_TO_STRING, this.GetType().Name, Name, WingSize, Weight, FoodEaten);
    }
}
