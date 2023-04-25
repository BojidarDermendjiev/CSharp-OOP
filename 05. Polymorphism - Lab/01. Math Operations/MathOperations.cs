namespace Operations
{
    public class MathOperations : IMathOperations
    {
        public MathOperations() { }
        public int Add(int firstElement, int secondElement)
        => firstElement + secondElement;

        public double Add(double firstElement, double secondElement, double thirdElement)
        => firstElement + secondElement + thirdElement;

        public decimal Add(decimal firstElement, decimal secondElement, decimal thirdElement)
        => firstElement + secondElement + thirdElement;
    }
}
