namespace _04._Pizza_Calories.Models.Modifiers.Dough
{
    using System;
    using System.Linq;
    using Contracts;
    using Utilities.Messages;

    public class Dough : IDough
    {
        private string flourType;
        private string bakingTechnique;
        private double grams;
        public Dough(string flourType, string brakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = brakingTechnique;
            Grams = grams;
        }
        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!new string[] { "White", "Wholegrain" }.Contains(value))
                    throw new Exception(string.Format(ExcaptionMessages.INVALID_TYPE_OF_DOUGH));
                flourType = value;

            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!new string[] { "Crispy", "Chewy", "Homemade" }.Contains(value))
                    throw new Exception(string.Format(ExcaptionMessages.INVALID_TYPE_OF_DOUGH));
                bakingTechnique = value;
            }
        }
        public double Grams
        {
            get => grams;
            private set
            {
                if (value < 1 || value > 200)
                    throw new Exception(string.Format(ExcaptionMessages.INVALID_CAPACITY_OF_GRAMS_FOR_DOUGH));
                grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                double caloriesPerGram = 2;
                IDough chewy = new Chewy(flourType, bakingTechnique);
                IDough crispy = new Crispy(flourType, bakingTechnique);
                IDough homemade = new Homemade(flourType, bakingTechnique);
                IDough white = new White(flourType, bakingTechnique);
                IDough wholegrain = new Wholegrain(flourType, bakingTechnique);
                if (this.flourType.ToLower() == "white")
                    caloriesPerGram *= white.Grams;
                else if (this.flourType.ToLower() == "wholegrain")
                    caloriesPerGram *= wholegrain.Grams;
                if (this.bakingTechnique.ToLower() == "crispy")
                    caloriesPerGram *= crispy.Grams;
                else if (this.bakingTechnique.ToLower() == "chewy")
                    caloriesPerGram *= chewy.Grams;
                else if (this.bakingTechnique.ToLower() == "homemade")
                    caloriesPerGram *= homemade.Grams;
                return caloriesPerGram;
            }
        }
        public double GetCalories()
            => CaloriesPerGram * grams;
    }
}
