namespace _04._Wild_Farm.Models.Animals.Mammal.Tiger
{
    using _04._Wild_Farm.Models.Foods;
    using _04._Wild_Farm.Utilities.Messages;
    using Feline;
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breeed) : base(name, weight, livingRegion, breeed) { }
        protected override string Breed { get; set; }
        protected override string LivingRegion { get; set; }
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }
        protected override double WeightGain => 1.00;
        public override void Eat(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
                System.Console.WriteLine(string.Format(OutputMessages.DOES_NOT_EAT, this.GetType().Name, food.GetType().Name));
            else
            {
                Weight += WeightGain * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }
        public override string Sound()
            => string.Format(OutputMessages.TIGER_ABILITY_TO_ASK_FOR_FOOD);
    }
}
