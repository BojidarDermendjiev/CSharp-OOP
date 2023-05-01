namespace _04._Wild_Farm.Models.Animals.Mammal
{
    using Foods;
    using Utilities.Messages;
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }
        protected override string LivingRegion { get; set; }
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }

        protected override double WeightGain => throw new System.NotImplementedException();
        public override void Eat(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
                System.Console.WriteLine(string.Format(OutputMessages.DOES_NOT_EAT, this.GetType().Name, food.GetType().Name));
            else
            {
                Weight += WeightGain + food.Quantity;
                FoodEaten += food.Quantity;
            }
        }
        public override string Sound()
            => string.Format(OutputMessages.DOG_ABILITY_TO_ASK_FOR_FOOD);
    }
}
