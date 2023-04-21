namespace _03._Shopping_Spree.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using _03._Shopping_Spree.Models;
    using Contracts;
    using Models.Contracts;
    public class ProductRepository : IRepositories<IProduct>
    {
        public List<IProduct> products;
        public ProductRepository()
        {
            products = new List<IProduct>();
        }
        public List<IProduct> Products { get => products; }
        public void Add(IProduct product)
        {
            products.Add(product);
        }
        public IProduct Find(string name)
            => products.FirstOrDefault(x => x.Name == name);
        public IReadOnlyCollection<IProduct> GetAll()
            => products.AsReadOnly();
        public void Remove(string guy) => products.Remove(products.FirstOrDefault(x => x.Name == guy));
    }
}
