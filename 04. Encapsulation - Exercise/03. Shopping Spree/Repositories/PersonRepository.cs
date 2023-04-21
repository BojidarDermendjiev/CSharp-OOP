namespace _03._Shopping_Spree.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Models.Contracts;
    using Repositories.Contracts;
    public class PersonRepository : IRepositories<IPerson>
    {
        public List<IPerson> people;
        public PersonRepository()
        {
            people = new List<IPerson>();
        }
        public void Add(IPerson guy)
        {
            people.Add(guy);
        }
        public IPerson Find(string guy)
            => people.FirstOrDefault(x => x.Name == guy);
        public IReadOnlyCollection<IPerson> GetAll() => people.AsReadOnly();
        public void Remove(string guy)
         => people.Remove(people.FirstOrDefault(x => x.Name == guy));
    }
}
