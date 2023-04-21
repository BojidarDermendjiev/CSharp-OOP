using System.Collections.Generic;

namespace _03._Shopping_Spree.Models.Contracts
{
    public interface IPerson
    {
        public string Name { get; }
        public decimal Money { get; }
        public IReadOnlyCollection<Product> Product { get; }
        public void BuyProduct(Product product);
    }
}
