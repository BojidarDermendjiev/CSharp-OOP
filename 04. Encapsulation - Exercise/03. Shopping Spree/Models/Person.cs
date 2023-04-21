namespace _03._Shopping_Spree.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Utilities.Messages;

    public class Person : IPerson
    {
        private string name;
        private decimal money;
        private readonly List<Product> products;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(string.Format(ExcaptionMessages.PERSON_NAME_CANNOT_BE_NULL_OR_WHITESPACE));
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                    throw new ArgumentException(string.Format(ExcaptionMessages.PERSON_AVAILABLE_MONEY_CANNOT_BE_NEGATIVE_NUMBER));
                money = value;
            }
        }

        public IReadOnlyCollection<Product> Product => products.AsReadOnly();

        public void BuyProduct(Product product)
        {
            if (money >= product.Cost)
            {
                this.money -= product.Cost;
                products.Add(product);
            }
        }
    }
}
