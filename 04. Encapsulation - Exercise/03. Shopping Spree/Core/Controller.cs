namespace _03._Shopping_Spree.Core
{
    using System.Linq;
    using System.Text;
    using Models;
    using Contracts;
    using Models.Contracts;
    using Repositories;
    using Utilities.Messages;
    using Repositories.Contracts;
    public class Controller : IController
    {
        private IRepositories<IPerson> person;
        private IRepositories<IProduct> product;
        public Controller()
        {
            person = new PersonRepository();
            product = new ProductRepository();
        }
        public string RegisterPerson(string name, decimal money)
        {
            if (this.person.Find(name) != default)
                return string.Format(OutputMessages.PERSON_ALREADY_CREATE, name);
            IPerson person = new Person(name, money);
            this.person.Add(person);
            return string.Format(OutputMessages.PERSON_WAS_CREATE_SUCCESSFULLY, name, money);
        }
        public string RegisterProduct(string name, decimal cost)
        {
            if (this.product.Find(name) != default)
                return string.Format(OutputMessages.PRODUCT_ALREADY_CREATE, name);
            IProduct product = new Product(name, cost);
            this.product.Add(product);
            return string.Format(OutputMessages.PRODUCT_WAS_CREATE_SUCCESSFULLY, name, cost);
        }
        public string Orders(string name, string orderProduct)
        {
            IPerson person = this.person.Find(name);
            IProduct product = this.product.Find(orderProduct);
            var matchProduct = new Product(product.Name, product.Cost);
            if (person != default && product != default && person.Money >= product.Cost)
            {
                person.BuyProduct(matchProduct);
                this.product.Add(product);
                return string.Format(OutputMessages.BUY_PRODUCT, name, orderProduct);
            }
            else
                return string.Format(OutputMessages.CANNOT_BUY_PRODUCT, name, product);
        }
        public string UsersReport()
        {
            var sb = new StringBuilder();
            foreach (var person in this.person.GetAll())
               sb.AppendLine(person.Product.Any() ? $"{person.Name} - {string.Join(", ", person.Product)}" : $"{person.Name} - Nothing bought.");
            return sb.ToString().TrimEnd();
        }
    }
}
