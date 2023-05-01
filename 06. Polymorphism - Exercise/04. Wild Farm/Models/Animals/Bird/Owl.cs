using _04._Wild_Farm.Utilities.Messages;

namespace _04._Wild_Farm.Models.Animals.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize){}
        protected override double WeightGain => 0.25;
        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
                System.Console.WriteLine(string.Format(OutputMessages.DOES_NOT_EAT, this.GetType().Name, food.GetType().Name));
            else
            {
                this.Weight += WeightGain * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
        }
        public override string Sound()
            => string.Format(OutputMessages.OWL_ABILITY_TO_ASK_FOR_FOOD);
    }
}
