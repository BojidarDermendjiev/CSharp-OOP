namespace _04._Pizza_Calories.Utilities.Messages
{
    public class ExcaptionMessages
    {
        public const string INVALID_TYPE_OF_DOUGH = "Invalid type of dough.";
        public const string INVALID_CAPACITY_OF_GRAMS_FOR_DOUGH = "Dough weight should be in the range [1..200].";
        public const string INVALID_TOPPING = "Cannot place {0} on top of your pizza.";
        public const string INVALID_CAPACITY_OF_GRAMS_FOR_TOPPING = "{0} weight should be in the range [1..50].";
        public const string PIZZA_NUMBER_SHOULD_BE_BETWEEN_1_TO_15SYMBOLS = "Pizza name should be between 1 and 15 symbols.";
        public const string PIZZA_TOPPING_CAPACITY_SHOULD_BE_IN_RANGE_TO_50 = "Number of toppings should be in range [0..10].";
    }
}
