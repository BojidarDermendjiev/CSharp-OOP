namespace _04._Wild_Farm.Models
{
    using Contracts;
    public class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
