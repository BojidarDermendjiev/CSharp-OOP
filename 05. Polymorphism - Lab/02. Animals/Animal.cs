namespace Animals
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private string favouriteFood;
        protected Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }
        public string Name
        { get => name; private set => name = value; }
        public string FavouriteFood
        { get => favouriteFood; private set => favouriteFood = value; }
        public virtual string ExceptionplainSelf()
            => $"I am {Name} and my favourite food is {FavouriteFood}";
    }
}
