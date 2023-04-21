namespace _04._Pizza_Calories.Models.Modifiers.Topping
{
    using System;
    using System.Linq;
    using Contracts;
    using Utilities.Messages;

    public class Topping : ITopping
    {
        private string typeOfProduct;
        private double grams;
        public Topping(string typeOfProduct, double grams)
        {
            TypeOfProduct = typeOfProduct;
            Grams = grams;
        }
        public string TypeOfProduct
        {
            get => typeOfProduct;
            private set
            {
                if (!new string[] { "Meat", "Veggies", "Cheese", "Sauce" }.Contains(value))
                    throw new Exception(string.Format(ExcaptionMessages.INVALID_TOPPING, typeOfProduct));
                typeOfProduct = value;
            }
        }
        public double Grams
        {
            get => grams;
            private set
            {
                if (value < 1 || value > 50)
                    throw new Exception(string.Format(ExcaptionMessages.INVALID_CAPACITY_OF_GRAMS_FOR_TOPPING, typeOfProduct));
                grams = value;
            }
        }
        public double CaloriesPerGram
        {
            get
            {
                double getCalories = 2;
                ITopping cheese = new Cheese(typeOfProduct);
                ITopping sauce = new Sauce(typeOfProduct);
                ITopping meat = new Meat(typeOfProduct);
                ITopping veggies = new Veggies(typeOfProduct);
                if (this.typeOfProduct.ToLower() == "cheese")
                    getCalories *= cheese.Grams;
                else if (this.typeOfProduct.ToLower() == "sauce")
                    getCalories *= sauce.Grams;
                else if (this.typeOfProduct.ToLower() == "meat")
                    getCalories *= meat.Grams;
                else if (this.typeOfProduct.ToLower() == "veggies")
                    getCalories *= veggies.Grams;

                return getCalories;
            }
        }
        public double GetCalories()
            => CaloriesPerGram * grams;
    }
}