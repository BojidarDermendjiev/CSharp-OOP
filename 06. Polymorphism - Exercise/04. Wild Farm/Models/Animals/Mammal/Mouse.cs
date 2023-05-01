using _04._Wild_Farm.Utilities.Messages;
using System.Linq;

namespace _04._Wild_Farm.Models.Animals.Mammal
{
    public class Mouse : Mammal
    {

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

        protected override string LivingRegion { get; set; }
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }
        protected override double WeightGain => 0.10;
        public override void Eat(Food food)
        {
            if (!new string[] { "Vegetable", "Fruit" }.Contains(food.GetType().Name))
                System.Console.WriteLine(string.Format(OutputMessages.DOES_NOT_EAT, this.GetType().Name, food.GetType().Name));
            else
            {
                Weight += WeightGain + food.Quantity;
                FoodEaten += food.Quantity;
            }
        }
        public override string Sound()
            => string.Format(OutputMessages.MOUSE_ABILITY_TO_ASK_FOR_FOOD);
    }
}
