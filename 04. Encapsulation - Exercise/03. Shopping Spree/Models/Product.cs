namespace _03._Shopping_Spree.Models
{
    using System;
    using Contracts;
    using Utilities.Messages;

    public class Product : IProduct
    {
        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(string.Format(ExcaptionMessages.PRODUCT_NAME_CANNOT_BE_NULL_OR_WHITESPACE));
                name = value;
            }
        }
        public decimal Cost
        {
            get => cost;
            private set
            {
                if (value < 0)
                    throw new ArgumentException(string.Format(ExcaptionMessages.PRODUCT_PRICE_CANNOT_BE_NEGATIVE_NUMBER));
                cost = value;
            }
        }
        public override string ToString()
            => this.Name;
    }
}
