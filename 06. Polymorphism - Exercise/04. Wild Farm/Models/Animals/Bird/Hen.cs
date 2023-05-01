using _04._Wild_Farm.Utilities.Messages;

namespace _04._Wild_Farm.Models.Animals.Bird
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize) { }
        protected override double WeightGain => 0.35;

        public override void Eat(Food food)
        {
            this.Weight += this.WeightGain * food.Quantity;
            this.FoodEaten += food.Quantity;
        }
        public override string Sound()
            => string.Format(OutputMessages.HEN_ABILITY_TO_ASK_FOR_FOOD);
    }
}
