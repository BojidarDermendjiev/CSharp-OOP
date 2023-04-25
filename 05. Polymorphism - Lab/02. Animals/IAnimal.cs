namespace Animals
{
    public interface IAnimal
    {
        public string Name { get; }
        public string FavouriteFood { get; }
        public string ExceptionplainSelf();
    }
}
