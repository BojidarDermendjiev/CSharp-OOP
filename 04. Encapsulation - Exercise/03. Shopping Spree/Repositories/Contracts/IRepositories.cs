namespace _03._Shopping_Spree.Repositories.Contracts
{
    using Models;
    using System.Collections.Generic;
    public interface IRepositories<T>
    {
        public void Add(T item);
        public void Remove(string item);
        public T Find(string identifier);
        public IReadOnlyCollection<T> GetAll();
    }
}
